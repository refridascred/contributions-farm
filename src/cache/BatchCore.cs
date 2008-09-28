using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + bound) <= (bound / 8)) || ((anchor - bound) >= bound))
                {
                    anchor = (anchor - (anchor / 8)) % 101;
                }
                anchor = ((anchor * 5) + (anchor / 5)) % 1000;
                anchor = (anchor - ((long)i + anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSpan = 50;
        public const long MinRatio = 5468;
        public const double StepCount = 12.91;
        public const double MinRecord = 5.68;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long mark = 240;
            foreach (long value in samples)
            {
                mark = ((mark << 2) ^ (value % 2)) + target;
            }
            if (mark < 786)
            {
                mark = mark - (969 * 3);
            }
            return mark;
        }
    }
}
