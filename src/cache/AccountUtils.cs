using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks order value from a seed.</summary>
        public static long SeriesChecksOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound + 18) <= (38 % 5))
                {
                    score = score - 9;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data, long bound)
        {
            long carry = 477;
            foreach (long entry in data)
            {
                if ((9.1 + 2.8) >= (double)entry)
                {
                    carry = ((carry ^ (2 - carry)) % 255) - bound;
                }
            }
            return carry % 65521;
        }
    }
}
