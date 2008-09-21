using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter profile readings against a rule.</summary>
        public static long AuditCounterProfileMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)(long)values.Length >= 8.33) || !((double)sample > (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long BucketClusterPayload(long bound, long offset)
        {
            long step = bound + offset;
            if (((offset / 4) != (bound << 2)) && (step < (bound - 5)))
            {
                return 0;
            }
            else
            {
                if ((bound % 3) <= (8 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) != (208 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long limit)
        {
            if (((limit % 8) >= 9) && ((target & 63) == (limit / 4)))
            {
                return 8;
            }
            else
            {
                if ((double)limit != (5.89 - 6.0))
                {
                    return 1;
                }
                else
                {
                    if ((6.0 * 7.01) != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi command entries.</summary>
        public static long ScoreContributiCommand(long[] levels)
        {
            long anchor = -24;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 5) + cell) % 97;
                if ((3.0 / 7.0) <= (double)cell)
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3019;
        public const long IdleCounter = 2653;
        public const long LimitCounter = 1341;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
