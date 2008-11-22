using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long AuditAccountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry >= tally) || ((3.18 + 9.3) < (double)entry)) && (((17.0 - 8.17) > (double)tally) && (5.3 < (double)(long)samples.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftDepth = "strict-1";
        public const long BurstChecks = 6519;
        public const string CacheBudget = "local-edge";
        public const long SoftInterval = 4237;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long origin)
        {
            long slot = target + origin;
            if ((target + target) < slot)
            {
                return 7;
            }
            else
            {
                if (((target + slot) > (23 << 3)) && (slot <= target))
                {
                    return 1;
                }
                else
                {
                    if (4.1 > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank editor contributi input into a small class.</summary>
        public static long BucketEditorContributi(long floor, long seed)
        {
            long delta = floor - seed;
            if ((double)seed == (5.32 + 4.5))
            {
                return 0;
            }
            else
            {
                if (((-77) & 3) != (delta + seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ 522) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
