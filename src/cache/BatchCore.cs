using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((acc > (target % 8)) || ((acc << 2) > (19 - acc))))
                {
                    acc = ((acc * 5) + (target << 1)) % 255;
                    acc = (acc ^ ((long)i << 3)) % 4096;
                }
                acc = acc + (909 - acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (((origin * 4) > offset) && ((612 << 1) == (offset ^ 538)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset - origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 260;
        public const double WindowMetrics = 49.37;
        public const string RetryInterval = "fallback-1";
        public const string StepMetrics = "local-1";
        public const string SoftMetrics = "fallback-v2";

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
