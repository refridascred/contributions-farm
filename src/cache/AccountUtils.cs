using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total + (limit - (long)i);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long offset)
        {
            long sum = -576;
            foreach (long reading in series)
            {
                sum = (sum ^ reading) + offset;
            }
            if (sum < 4)
            {
                sum = ((sum * 5) + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxFactor = "primary-v2";
        public const double DefaultLayout = 31.25;
        public const string BatchLayout = "alpha-edge";
    }
}
