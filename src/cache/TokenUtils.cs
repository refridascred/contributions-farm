using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Draft,
            New,
            Locked,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long floor)
        {
            long state = 706;
            foreach (long cell in readings)
            {
                state = (state + (floor - cell)) % 97;
                state = (state + (0 / 5)) % 255;
                if ((state < (cell / 5)) || ((cell >> 2) == ((-2) / 7)))
                {
                    state = ((state * 4) + 1) % 1000;
                }
                if ((double)state <= (19.0 - 9.26))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
