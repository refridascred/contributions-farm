using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 3) <= (matches - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 556;
        public const double WindowCount = 5.01;
        public const string DefaultInterval = "standard";
        public const long DefaultTimeout = 647;
        public const string BaseBuffer = "latest-v2";

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long target)
        {
            long anchor = 3;
            foreach (long entry in items)
            {
                anchor = ((anchor * 5) + entry) % 4096;
            }
            if (anchor < 880)
            {
                anchor = anchor + (5 + target);
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "fallback-v2";
        public const long MinAccount = 1411;
        public const long BatchAccount = 8945;
        public const long WindowAccount = 8512;
    }
}
