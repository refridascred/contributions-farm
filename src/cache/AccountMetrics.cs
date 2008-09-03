using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long sum = 3;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ sum) % 255) + datum;
                sum = (sum + (0 * 3)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Scale a session queue figure with a bias.</summary>
        public static double SmoothSessionQueue(double gain, double span)
        {
            double rate = span / 2.0;
            if (rate >= (16.0 + gain))
            {
                rate = rate - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 8.0)) - (double)(long)i;
            }
            return rate - (double)58;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long floor)
        {
            if (floor >= (floor ^ offset))
            {
                return 6;
            }
            else
            {
                if ((7.4 + 3.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (((offset + floor) > (offset - floor)) || ((offset + 3) != (floor % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset >= (14.0 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long TallyMetricsSupportOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - 597) <= (value % 5))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
