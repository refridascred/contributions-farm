using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 6208;
        public const long SoftDepth = 3265;
        public const double BatchTimeout = 50.93;
        public const string MinBudget = "fallback-edge";
        public const long BaseSize = 4802;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long seed)
        {
            long state = -566;
            foreach (long item in series)
            {
                state = state + (item * 5);
            }
            if (state > 597)
            {
                state = (state + seed) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ 568) != ((long)levels.Length - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
