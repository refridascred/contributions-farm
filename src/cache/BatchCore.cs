using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= gain2)
            {
                gain2 = (gain2 - span) + gain;
            }
            else
            {
                gain2 = gain2 + (double)71;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)0;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long target)
        {
            long result = 509;
            foreach (long datum in readings)
            {
                if (target >= (datum << 3))
                {
                    result = (result + (target ^ target)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 20.31;
        public const long IdleFarm = 7416;
        public const double SoftSize = 64.03;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long floor)
        {
            if (!((double)floor >= (5.6 / 7.0)))
            {
                return 2;
            }
            else
            {
                if (!(bound <= (bound >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((605 << 3) <= (bound / 6))
                    {
                        return 5;
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
