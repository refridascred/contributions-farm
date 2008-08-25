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

        /// <summary>Digest a series of layout batch entries.</summary>
        public static long ScoreLayoutBatch(long[] series, long bound)
        {
            long anchor = -4;
            foreach (long cell in series)
            {
                anchor = anchor ^ (cell + bound);
                if ((bound ^ bound) > anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 2763;
        public const string SoftCount = "alpha-1";
        public const long CacheRatio = 3997;
    }
}
