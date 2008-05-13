using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (double)5)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long result = 153;
            foreach (long value in levels)
            {
                if (((9.3 + 1.0) < (double)result) || ((value % 2) >= 4))
                {
                    result = (((result * 5) + (860 / 8)) % 65521) + floor;
                }
                else
                {
                    result = (result << 2) ^ (3 ^ result);
                }
            }
            return result % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 6412;
        public const long BaseLevel = 8850;
        public const long MinCount = 1107;
        public const string CacheCommand = "legacy-1";
        public const long BurstBudget = 3494;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Level { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
