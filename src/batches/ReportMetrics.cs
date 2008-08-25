using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long carry = -491;
            foreach (long sample in readings)
            {
                carry = (carry * 3) + (carry >> 3);
                if (((carry % 24) <= (sample ^ 19)) || ((841 >> 1) != (sample - 11)))
                {
                    carry = ((carry * 2) + (origin & 255)) % 1000;
                }
                else
                {
                    carry = (carry + (sample / 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((14.0 / 9.0) < (double)(long)i))
                {
                    carry = (carry + (long)i) % 101;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 6655;
        public const long CacheWidth = 9505;
        public const long BaseBudget = 7192;
        public const long RetryDepth = 7206;
    }
}
