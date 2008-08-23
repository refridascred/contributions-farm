using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen & 31) < (offset >> 2)) && (offset < (seen + offset)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long MeasureFarmProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + seen) != (reading >> 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinInterval = "local";
        public const double BaseAccount = 75.53;
        public const string BatchAccount = "fallback-edge";
        public const long WindowScore = 6432;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long floor2)
        {
            long delta = floor + floor2;
            if (delta > floor)
            {
                return 2;
            }
            else
            {
                if ((floor << 3) >= (floor >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((3.4 / 4.0) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta >= (floor2 + 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
