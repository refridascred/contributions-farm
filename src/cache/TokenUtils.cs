using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark + (2 >> 5)) % 1000) + (long)i2;
                    mark = (mark + (limit / 8)) % 65521;
                }
                mark = mark - (-6);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 3385;
        public const string StepCommits = "primary-edge";
        public const long DefaultCommits = 342;
    }
}
