using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double span)
        {
            double weight = (double)(1 & 255);
            if (weight < (ratio - weight))
            {
                weight = (weight - (double)5) + span;
            }
            return weight - (0.8 / 6.0);
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long AuditRouteMetricGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally <= (tally + bound)) && (cell >= (bound + bound)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
