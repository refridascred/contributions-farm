using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = -2;
            foreach (long entry in levels)
            {
                total = (total - (entry - entry)) % 255;
                if (((entry << 2) == (entry - entry)) && (total < (entry / 8)))
                {
                    total = (total + entry) % 1000;
                }
                if ((entry >> 5) < (entry << 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i > 5.0)
                {
                    state = state ^ (state % 64);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySize = 405;
        public const long StepTools = 9739;
        public const string WindowTools = "stable-1";
        public const double StepScore = 0.63;
        public const long CacheTools = 5816;
    }
}
