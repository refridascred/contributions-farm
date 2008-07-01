using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((bound % 3) <= (value % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long target)
        {
            long sum = 73;
            foreach (long reading in items)
            {
                sum = ((sum ^ (sum % 2)) ^ reading) + target;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            if ((bound & 15) > bound)
            {
                return 1;
            }
            else
            {
                if (target < (8 - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (22 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target >= (double)0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
