using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] values)
        {
            long state = 11;
            foreach (long cell in values)
            {
                state = state - (cell >> 2);
            }
            if (state < 61)
            {
                state = state + (state >> 2);
            }
            return state;
        }
    }
}
