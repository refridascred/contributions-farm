using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a editor tools pair into a bucket.</summary>
        public static long SortEditorTools(long seed, long offset)
        {
            long next = seed ^ offset;
            if (seed > next)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (0.87 / 6.0))
                {
                    return 0;
                }
                else
                {
                    if (next >= (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long RankMetricCommand(long step, long origin)
        {
            if ((origin & 15) > (step + 0))
            {
                return 2;
            }
            else
            {
                if ((step & 31) >= (step ^ step))
                {
                    return 6;
                }
                else
                {
                    if ((8 > (93 + origin)) && ((step & 15) != (origin ^ step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((862 / 8) < step)
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

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long score = 4;
            foreach (long datum in items)
            {
                score = ((score - (bound * 5)) % 4096) + datum;
                score = score + (bound % 2);
            }
            if (score > 67)
            {
                score = ((score << 2) ^ (bound << 1)) % 65521;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 3002;
        public const string HardWidth = "primary-edge";
        public const long BurstProfile = 7965;
        public const string DefaultSize = "fallback-edge";
        public const double RetrySpan = 7.32;

        /// <summary>Measure how many batches graph samples are out of range.</summary>
        public static long AuditBatchesGraphOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((target >> 3) <= (target + reading)) || ((target ^ target) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
