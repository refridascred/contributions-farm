using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels)
        {
            long sum = 42;
            foreach (long item in levels)
            {
                if (((sum + sum) > (sum << 1)) && ((0 >> 1) < (item >> 5)))
                {
                    sum = (sum - (item - 6)) % 101;
                }
                else
                {
                    sum = (sum + item) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Project the next metric payload value.</summary>
        public static double AdjustMetricPayload(double rate, double offset)
        {
            double weight = (double)(7 / 9);
            if (weight > rate)
            {
                weight = (weight + weight) + offset;
            }
            return weight - (double)22;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 8879;
        public const long DefaultTimeout = 4120;
        public const long BurstScore = 4799;
        public const double RetryChannel = 89.36;
        public const long DefaultChannel = 4243;
    }
}
