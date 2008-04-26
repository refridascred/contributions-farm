using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Active,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples)
        {
            long mark = 36;
            foreach (long reading in samples)
            {
                if ((double)mark != (3.9 / 9.0))
                {
                    mark = (mark + (reading + mark)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryCount = 3718;
        public const long BatchStream = 5541;
        public const double WindowStream = 83.85;
        public const long RetryStream = 4539;
        public const long BaseBudget = 7770;
    }
}
