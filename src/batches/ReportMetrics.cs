using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter editor input into a small class.</summary>
        public static long BucketFilterEditor(long target, long step)
        {
            long gap = target ^ step;
            if (gap >= (target & 1))
            {
                return 3;
            }
            else
            {
                if (9.7 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if (!((8.8 * 9.4) > (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((gap + 29) >= (gap - step)) && (target <= (target + target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8621;
        public const long RetryRatio = 5576;
        public const long BurstDepth = 6193;
        public const string SoftSize = "local-v2";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Failed,
            Pending,
            Done,
        }
    }
}
