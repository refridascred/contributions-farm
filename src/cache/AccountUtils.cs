using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] values, long offset)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if (state >= (state >> 1))
                {
                    state = ((state + offset) % 4096) ^ reading;
                }
            }
            if (state > 324)
            {
                state = (state - (state - state)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings, long step)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (item / 4)) + step;
            }
            return sum % 1000;
        }
    }
}
