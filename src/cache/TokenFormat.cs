using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long floor)
        {
            long prev = bound - floor;
            if ((floor - floor) >= (prev + floor))
            {
                return 3;
            }
            else
            {
                if (!((floor >> 5) <= bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double rate = (floor - floor) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > (cell ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
