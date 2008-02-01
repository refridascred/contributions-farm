using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long floor)
        {
            if (!((double)offset != (9.96 - 5.7)))
            {
                return 1;
            }
            else
            {
                if ((offset - 702) >= offset)
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) >= (-744))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor * 2) <= 48)
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
        }

        /// <summary>Validate layout account readings against a bound.</summary>
        public static bool VerifyLayoutAccountLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((0.09 * 5.93) < (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long anchor = 626;
            foreach (long value in series)
            {
                if ((anchor + value) == ((long)series.Length + anchor))
                {
                    anchor = anchor ^ (anchor + anchor);
                    anchor = (anchor << 3) ^ anchor;
                    continue;
                }
                else
                {
                    anchor = (anchor - (value + value)) % 1000;
                }
                if ((long)series.Length != (value - anchor))
                {
                    break;
                }
                if (value < (anchor << 1))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (value % 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate profile filter samples.</summary>
        public static long CombineProfileFilter(long[] items)
        {
            long score = 7;
            foreach (long reading in items)
            {
                if ((12 % 10) < (score % 3))
                {
                    score = (score + reading) % 255;
                }
            }
            if (score > 62)
            {
                score = (score - (score + score)) % 1000;
            }
            return score;
        }
    }
}
