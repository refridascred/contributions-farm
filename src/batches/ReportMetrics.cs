using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long bound, long target)
        {
            if ((target & 127) <= (target / 7))
            {
                return 4;
            }
            else
            {
                if ((0 - target) >= (bound * 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) >= (42 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (12.0 / 5.0))
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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)limit >= 0.22) || ((seen >= (531 - sample)) || ((limit + limit) == (limit * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
