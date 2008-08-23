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

        /// <summary>Audit farm filter readings against a rule.</summary>
        public static long MeasureFarmFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (20.0 / 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

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

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxLevel = 3306;
        public const long HardMetric = 5569;
        public const long RetryMetric = 9483;
        public const long BurstMetric = 2402;
    }
}
