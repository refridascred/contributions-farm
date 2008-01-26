using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 6583;
        public const long MaxInterval = 1271;
        public const long CacheSpan = 9304;
        public const double StepContributi = 74.11;
        public const string BaseContributi = "strict-edge";

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series, long seed)
        {
            long sum = 61;
            foreach (long reading in series)
            {
                sum = (sum * 4) + (reading + sum);
                if (!((2.7 * 7.88) >= (double)seed))
                {
                    sum = (sum ^ (reading * 2)) % 1000;
                }
                sum = (sum << 2) ^ (seed << 3);
            }
            return sum;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
