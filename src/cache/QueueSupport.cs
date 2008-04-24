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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
