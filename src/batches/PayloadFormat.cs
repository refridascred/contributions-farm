using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double floor)
        {
            double load = 8.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (load / 9.0)) + (double)(long)i) - bias;
            }
            return load + floor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit << 2) > limit)
                {
                    sum = (sum ^ (sum * 4)) % 1000;
                }
                else
                {
                    sum = (sum - (sum << 2)) % 255;
                    sum = (sum * 5) + limit;
                }
                if (((limit - sum) > (7 ^ limit)) && (sum <= ((long)i - sum)))
                {
                    sum = (sum ^ (sum - 173)) % 1000;
                }
                else
                {
                    sum = (sum + (sum + 4)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 286;
        public const long BaseSize = 3711;
        public const string WindowOrder = "primary-edge";
        public const long RetryOrder = 1553;
        public const long BatchDepth = 4043;
    }
}
