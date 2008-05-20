using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 64;
            foreach (long datum in values)
            {
                if ((7.0 - 8.0) < (double)datum)
                {
                    total = (total + ((long)values.Length / 5)) % 101;
                }
                if ((total & 127) == (total - datum))
                {
                    break;
                }
            }
            if (total < 998)
            {
                total = (total << 2) ^ (total % 64);
            }
            return total % 65521;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            long lane = seed ^ floor;
            if (((lane >> 1) <= (seed + lane)) && ((0 ^ floor) > (seed >> 2)))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (16.0 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((lane ^ 49) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((782 & 127) == (lane % 100))
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

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = (drift - drift) + ratio;
            }
            else
            {
                drift = drift - (drift * 5.1);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (7.0 + 4.0)) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryDepth = "latest";
        public const long LimitDepth = 1791;
        public const double CacheContext = 95.07;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long floor)
        {
            long gap = step - floor;
            if (((floor + gap) < (0 ^ step)) || ((gap << 2) >= (gap - step)))
            {
                return 7;
            }
            else
            {
                if ((double)step == (1.86 - 18.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)gap == (19.0 - 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 2) != (step / 2))
                        {
                            return 5;
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
