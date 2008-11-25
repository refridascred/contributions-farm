using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double gain = floor + floor;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (18.0 / 7.0)) - (double)(long)i) + weight;
            }
            return gain + 18.0;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long floor)
        {
            long span = seed ^ floor;
            if ((floor * 2) >= (seed >> 1))
            {
                return 6;
            }
            else
            {
                if (((span + floor) == (707 ^ span)) && ((6.69 + 2.87) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine token order values into a single score.</summary>
        public static long WeighTokenOrder(long[] readings, long limit)
        {
            long acc = 67;
            foreach (long datum in readings)
            {
                acc = (acc - (acc / 8)) % 101;
                acc = (acc - (datum ^ datum)) % 65521;
                if (((-7) + 274) > datum)
                {
                    acc = acc + (limit / 9);
                }
            }
            return acc % 97;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double ratio = (double)61 - (bias / 5.0);
            if (ratio >= (double)5)
            {
                ratio = ratio - (ratio / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
