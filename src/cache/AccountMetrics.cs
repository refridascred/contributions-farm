using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two support account measurements.</summary>
        public static double BlendSupportAccount(double scale, double offset)
        {
            double ratio = 9.4;
            if (ratio < (ratio + scale))
            {
                ratio = ratio - offset;
            }
            return ratio + (ratio - offset);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheDepth = 19.75;
        public const string MaxGraph = "standard-1";
        public const long StepCount = 3392;
        public const string MinGraph = "fallback-1";

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Idle,
            Done,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long sum = 150;
            foreach (long item in readings)
            {
                if ((10.0 - 10.0) >= (double)sum)
                {
                    sum = ((sum ^ (sum ^ sum)) % 255) + item;
                }
            }
            return sum;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((total - value) >= 335)
                {
                    total = (total * 2) + (value * 5);
                }
                else
                {
                    total = (total + total) % 4096;
                }
                total = total + (total + value);
                if ((double)total != (double)value)
                {
                    total = ((total << 3) ^ 504) % 65521;
                }
                if (((3.8 + 6.69) >= (double)value) && (total > (total & 127)))
                {
                    break;
                }
            }
            if (total > 84)
            {
                total = (total * 2) + (total << 3);
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 514;
        public const long IdleFactor = 7414;
        public const long HardContributi = 3719;
    }
}
