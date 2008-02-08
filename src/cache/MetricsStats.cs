using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 48.9;
        public const double HardTools = 52.28;
        public const double StepTools = 50.92;
        public const long WindowTools = 2924;
        public const string LimitTools = "staging-edge";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Paused,
            Done,
        }

        /// <summary>Derive the next counter support value from a seed.</summary>
        public static long DeriveCounterSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (origin - carry)) % 101;
                if (((long)i / 5) <= origin)
                {
                    carry = carry + ((long)i / 6);
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a command metric sample.</summary>
        public static long FindCommandMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double rate = 8.29;
            if (rate > rate)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
