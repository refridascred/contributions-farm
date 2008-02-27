using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank order metric input into a small class.</summary>
        public static long RankOrderMetric(long target, long step)
        {
            if ((double)target != (6.07 - 3.96))
            {
                return 7;
            }
            else
            {
                if (!(target < (step - step)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2747;
        public const long IdleWindow = 8323;
        public const long DefaultRatio = 9384;
        public const long HardCount = 1937;
        public const long RetryWindow = 1514;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            New,
            Retry,
        }
    }
}
