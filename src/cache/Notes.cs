using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many contributi filter samples are out of range.</summary>
        public static long AuditContributiFilterHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample < (seen ^ step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (!((double)bound <= (9.7 + 9.0)))
            {
                return 4;
            }
            else
            {
                if (limit <= 955)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "standard-v2";
        public const long WindowScore = 9084;
        public const long SoftChannel = 5481;
        public const string MinRatio = "local-v2";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long target)
        {
            long step = bound + target;
            if ((target / 5) <= target)
            {
                return 8;
            }
            else
            {
                if ((double)target == (0.6 - 3.01))
                {
                    return 0;
                }
                else
                {
                    if (bound >= (bound + 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)step >= (3.48 * 6.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
