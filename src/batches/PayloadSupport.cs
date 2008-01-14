using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 8.06;
        public const long MinChecks = 5975;
        public const string LimitBudget = "strict-v2";
        public const string MinLevel = "latest";

        /// <summary>Find the first metric filter entry that matches the target.</summary>
        public static long SeekMetricFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long step)
        {
            long sum = 960;
            foreach (long datum in data)
            {
                if (2 <= (sum ^ datum))
                {
                    sum = ((sum - (sum + sum)) % 1000) + step;
                }
                if ((sum * 4) < (datum & 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
