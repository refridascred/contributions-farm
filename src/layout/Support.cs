using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long target)
        {
            if (((floor ^ floor) < target) && ((target % 64) > (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (!(6.29 < (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((92 + floor) > ((-99) * 5)) && ((target >> 4) >= (49 + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - floor) > (target + 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((7.1 / 2.0) == (double)sum) && (8.0 >= (double)sum))
                {
                    sum = sum + (sum - 5);
                }
                else
                {
                    long matches = origin;
                    sum = (sum - (origin ^ matches)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < (double)71)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain + (double)262;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (0.6 * 9.3)) + (double)(long)i;
            }
            return gain + (gain - ratio);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen < (6.8 - 4.5))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
