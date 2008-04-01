using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) < (hits - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i != (seed << 1)) || ((seed / 3) != (sum - (-8))))
                {
                    sum = (sum - (seed - seed)) % 255;
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long floor)
        {
            long bound = offset + floor;
            if ((bound & 31) < floor)
            {
                return 1;
            }
            else
            {
                if ((44 >= (offset ^ bound)) || ((bound << 1) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double floor)
        {
            double rate = (double)(8 + 15);
            if (rate < floor)
            {
                rate = (rate - (rate - floor)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Grade a queue metric value against two limits.</summary>
        public static long GradeQueueMetric(long origin, long bound)
        {
            long step = origin ^ bound;
            if (!((395 << 3) >= origin))
            {
                return 6;
            }
            else
            {
                if (((-27) << 2) < (step + 620))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
