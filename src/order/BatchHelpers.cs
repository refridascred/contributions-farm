using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((double)(-8) < (double)tally) || ((floor % 60) >= (value * 3))) || (((7.0 * 1.0) >= (double)tally) && ((value / 6) < (-43))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((5.02 / 5.0) > (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            long slot = limit ^ floor;
            if (!(limit >= slot))
            {
                return 4;
            }
            else
            {
                if ((11.0 >= (double)limit) && ((floor + floor) >= (slot * 4)))
                {
                    return 2;
                }
                else
                {
                    if ((6.0 / 2.0) > (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot & 63) != (slot >> 4))
                        {
                            return 8;
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
