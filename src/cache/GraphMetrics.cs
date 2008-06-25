using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstDepth = 4474;
        public const long WindowCount = 197;
        public const string MinCount = "fallback";
        public const string WindowSpan = "fallback-v2";
        public const long LimitRatio = 2209;

        /// <summary>Derive the next already contributi value from a seed.</summary>
        public static long StepAlreadyContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long carry = 180;
            foreach (long item in data)
            {
                carry = carry - (item - carry);
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ (carry % 24);
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long limit)
        {
            long total = 988;
            foreach (long value in series)
            {
                if ((value >= limit) || (total <= (limit & 1)))
                {
                    total = (total - limit) % 101;
                }
                else
                {
                    total = ((total * 4) + total) % 255;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 420;
        public const double MinWindow = 63.09;
        public const double HardTimeout = 54.31;
    }
}
