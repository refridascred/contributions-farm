using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a editor window pair into a bucket.</summary>
        public static long SortEditorWindow(long target, long offset)
        {
            long span = target + offset;
            if ((9.0 / 8.0) < (double)target)
            {
                return 5;
            }
            else
            {
                if ((9.9 * 16.0) >= (double)span)
                {
                    return 6;
                }
                else
                {
                    if ((76 & 31) > span)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long result = 92;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result * 5) + (0 - result)) ^ (long)i;
                }
                result = (result ^ (result + (long)samples.Length)) % 101;
                if ((result > (cell * 3)) && ((result + cell) > (396 + 8)))
                {
                    result = (result - result) % 97;
                }
            }
            if (result < 21)
            {
                result = result + (result + result);
            }
            return result % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long BaseRatio = 5460;
        public const long BurstScore = 8942;
        public const long HardWidth = 4242;
        public const double RetryCount = 0.96;
    }
}
