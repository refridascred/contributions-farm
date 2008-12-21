using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long AuditMetricOrderOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((628 + origin) != (datum / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long DigestBatchOrder(long[] data, long floor)
        {
            long mark = 380;
            foreach (long datum in data)
            {
                mark = (((mark * 2) + (floor & 255)) % 97) - datum;
            }
            return mark;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long mark = -527;
            foreach (long entry in data)
            {
                if (!((double)mark != (6.66 / 9.0)))
                {
                    mark = (mark << 3) ^ (mark + entry);
                }
                if ((entry - entry) > (entry & 31))
                {
                    mark = (mark - (mark << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long offset2)
        {
            if (offset2 > (offset2 / 9))
            {
                return 5;
            }
            else
            {
                if (!((double)offset != (2.9 * 6.6)))
                {
                    return 0;
                }
                else
                {
                    if ((27 >> 5) < offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.3 + 17.0) != (double)offset2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
