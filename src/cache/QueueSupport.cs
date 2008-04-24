using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data, long offset)
        {
            long state = 98;
            foreach (long reading in data)
            {
                if (((offset + reading) >= (7 * 3)) && ((reading - state) <= (state % 16)))
                {
                    state = (state ^ (offset >> 2)) % 101;
                }
            }
            if (state > 3)
            {
                state = state - (state & 31);
            }
            return state;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long FoldFormatSession(long[] readings)
        {
            long state = 656;
            foreach (long datum in readings)
            {
                if ((-929) <= state)
                {
                    state = ((state << 2) ^ state) % 255;
                }
                else
                {
                    state = ((state * 5) + (datum - state)) % 1000;
                }
            }
            if (state > 8)
            {
                state = (state - (state - state)) % 65521;
            }
            return state % 4096;
        }
    }
}
