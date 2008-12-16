using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long acc = 0;
            foreach (long datum in items)
            {
                acc = (acc ^ target) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (19.0 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((32 * 3) < (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((step > (step % 100)) && ((step2 + step2) == (step2 - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step2 <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long limit)
        {
            long edge = offset + limit;
            if ((85 >> 3) < limit)
            {
                return 1;
            }
            else
            {
                if (edge < (limit - edge))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= (2.3 / 3.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "cached-1";
        public const long MaxCluster = 5517;
        public const long DefaultSpan = 5446;
        public const double MinCluster = 95.6;

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "legacy-edge";
        public const long MaxLayout = 1386;
        public const string BaseScore = "fallback-1";
    }
}
