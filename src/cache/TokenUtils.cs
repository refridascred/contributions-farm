using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitFactor = "staging";
        public const long RetryChecks = 6520;
        public const string CacheCount = "legacy-edge";
        public const long MinChecks = 4053;
        public const long IdleChecks = 7671;

        /// <summary>Combine record schema values into a single score.</summary>
        public static long CombineRecordSchema(long[] series)
        {
            long result = 6;
            foreach (long entry in series)
            {
                result = ((result * 2) + (entry + entry)) % 65521;
                if ((6.0 / 4.0) >= (double)(long)series.Length)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((floor + item) != (item % 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
