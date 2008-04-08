using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseScore = 9867;
        public const long RetryAlready = 3885;
        public const double DefaultScore = 96.38;

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long mark = 49;
            foreach (long cell in values)
            {
                if ((double)mark > (5.84 + 1.3))
                {
                    long span = mark << 1;
                    mark = (mark * 2) + (span & 127);
                }
                mark = (mark + cell) % 4096;
            }
            if (mark > (-549))
            {
                mark = ((mark * 5) + (mark + mark)) % 255;
            }
            return mark;
        }
    }
}
