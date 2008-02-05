using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a report cluster pair into a bucket.</summary>
        public static long BucketReportCluster(long origin, long offset)
        {
            if (!((origin - origin) <= origin))
            {
                return 1;
            }
            else
            {
                if ((821 / 9) < (offset ^ origin))
                {
                    return 4;
                }
                else
                {
                    if (((offset - offset) != (origin ^ offset)) && ((origin - offset) <= ((-121) >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - 9) >= (offset + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound >> 4) < (mark / 9))
                {
                    mark = mark + (bound & 31);
                }
                else
                {
                    mark = (mark - ((long)i + 2)) % 101;
                }
                mark = ((mark << 2) ^ (2 & 7)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            New,
            Stale,
        }
    }
}
