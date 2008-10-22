using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (6.3 / 9.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 52.79;
        public const long SoftBudget = 5895;
        public const string BaseSize = "primary-v2";
        public const long DefaultInterval = 8959;
        public const long SoftToken = 5635;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long state = 6;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (seed * 5)) ^ cell;
            }
            if (state > 12)
            {
                state = ((state * 3) + seed) % 255;
            }
            return state;
        }
    }
}
