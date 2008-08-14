using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (sum / 7)) % 1000;
                if ((long)i != (sum + 3))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 366;
        public const string MinDepth = "primary";
        public const string DefaultBudget = "standard-edge";
        public const double MinMetric = 96.94;
        public const long RetrySize = 9891;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
