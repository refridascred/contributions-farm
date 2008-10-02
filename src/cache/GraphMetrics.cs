using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long bound, long limit)
        {
            if ((7.2 + 6.95) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (bound >= 3)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two counter token measurements.</summary>
        public static double SmoothCounterToken(double scale, double bias)
        {
            double scale2 = (double)(60 + 42);
            if (scale2 < (scale2 * 2.3))
            {
                scale2 = ((scale2 + 7.84) - scale) - bias;
            }
            return scale2 - (double)42;
        }
    }
}
