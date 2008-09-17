using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)seen >= 11.0))
                {
                    seen = ((seen + 2) ^ datum) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long ScoreFormatMetrics(long[] data, long floor)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                mark = (mark * 4) + (floor + floor);
                if ((datum < mark) && ((mark ^ floor) <= floor))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = (mark - (floor + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((bound >> 4) >= (offset & 63))
            {
                return 1;
            }
            else
            {
                if (13.0 > (7.07 * 4.83))
                {
                    return 0;
                }
                else
                {
                    if (((38 + 5) >= (offset ^ seed)) && (17.0 <= (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset >= (offset & 7)) || (bound < offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Done,
            Draft,
            Queued,
            Dropped,
        }
    }
}
