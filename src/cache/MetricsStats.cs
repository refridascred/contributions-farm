using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 77.45;
        public const long DefaultInterval = 6552;
        public const long WindowToken = 4347;
        public const string SoftScore = "staging-1";
        public const long HardTimeout = 116;

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long target)
        {
            long slot = step ^ target;
            if (target < (slot + 5))
            {
                return 6;
            }
            else
            {
                if ((77 / 4) < slot)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 1028;
        public const double DefaultSpan = 0.76;
        public const double StepChannel = 2.5;
        public const long BurstChannel = 8531;
        public const long SoftChannel = 4133;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count ^ origin) != (count % 97))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
