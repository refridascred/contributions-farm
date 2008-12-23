using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 8130;
        public const string LimitProfile = "cached-1";
        public const double HardProfile = 95.75;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)3)
            {
                scale = scale - (offset / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight / 3.0)) + (double)(long)i;
            }
            return scale - (double)0;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 3) > value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
