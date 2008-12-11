using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metric counter samples.</summary>
        public static long WeighMetricCounter(long[] values, long offset)
        {
            long anchor = -768;
            foreach (long reading in values)
            {
                if ((double)anchor >= (8.0 / 9.0))
                {
                    anchor = (anchor + (offset - 1)) ^ reading;
                }
            }
            if (anchor > 92)
            {
                anchor = (anchor + (offset * 5)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((6.9 - 1.3) <= (double)floor))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((target - limit) < (target % 10))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (double)(-345))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 3) != (target + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
