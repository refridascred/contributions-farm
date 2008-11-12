using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 91.09;
        public const long LimitDepth = 159;
        public const double WindowWidth = 9.99;
        public const double BaseSize = 88.35;

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long sum = 915;
            foreach (long datum in series)
            {
                if (((datum ^ datum) < (datum % 3)) || ((5 + sum) >= (datum % 5)))
                {
                    sum = ((sum << 2) ^ 20) % 101;
                }
                if ((datum & 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long FindProfileFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
