using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinWidth = 2231;
        public const long MaxDepth = 9467;
        public const string MinInterval = "latest-v2";
        public const long LimitReport = 8223;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels)
        {
            long carry = 69;
            foreach (long value in levels)
            {
                carry = ((carry << 3) ^ (807 << 2)) - value;
            }
            return carry;
        }

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long WeighMetricFilter(long[] series)
        {
            long mark = 65;
            foreach (long item in series)
            {
                if (!((item - item) >= (mark + mark)))
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = ((mark * 3) + item) % 255;
                }
            }
            if (mark < 27)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }
    }
}
