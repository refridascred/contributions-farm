using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long limit, long bound)
        {
            long lane = limit ^ bound;
            if ((limit >> 4) != (315 ^ limit))
            {
                return 1;
            }
            else
            {
                if ((794 / 3) != (lane ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((0.7 + 5.0) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound < lane)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)offset > (2.3 * 13.0)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Combine metric command values into a single score.</summary>
        public static long ScoreMetricCommand(long[] levels)
        {
            long mix = 528;
            foreach (long reading in levels)
            {
                if (mix <= reading)
                {
                    mix = (mix << 2) ^ (reading & 3);
                }
            }
            return mix % 97;
        }
    }
}
