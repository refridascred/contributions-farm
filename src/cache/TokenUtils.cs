using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 6743;
        public const double StepRatio = 18.26;
        public const long StepEntry = 9600;
        public const long RetryEntry = 8545;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = (mark << 3) ^ (sample % 24);
            }
            return mark;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long AuditRouteCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((602 & 63) != (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
