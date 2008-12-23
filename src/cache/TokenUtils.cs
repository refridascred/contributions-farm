using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next already commits value from a seed.</summary>
        public static long StepAlreadyCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result << 2) ^ ((long)i2 << 2);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 878;
            foreach (long value in readings)
            {
                if ((sum << 1) > (value / 2))
                {
                    sum = ((sum * 3) + 626) % 65521;
                }
                if ((double)sum != (double)value)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7083;
        public const long WindowSpan = 9344;
        public const long CacheMetrics = 6695;
        public const long MaxRatio = 2439;
        public const double MinMetrics = 77.24;
    }
}
