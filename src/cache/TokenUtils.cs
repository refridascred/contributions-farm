using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                if ((double)value < (7.26 - 3.24))
                {
                    result = (result + (result - result)) % 255;
                }
                result = (result ^ (4 % 97)) % 65521;
                if (result <= (result ^ value))
                {
                    result = ((result * 3) + (result + value)) % 65521;
                }
            }
            if (result < 40)
            {
                result = (result ^ (result & 3)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBudget = 4947;
        public const double MaxSpan = 6.61;
        public const string MaxDepth = "primary-1";
        public const string BatchBudget = "strict-v2";
        public const long RetryBuffer = 9681;

        /// <summary>Audit support window readings against a rule.</summary>
        public static long TallySupportWindowGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)target > (10.0 / 5.0))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
