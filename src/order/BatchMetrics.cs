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

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftSize = 51.61;
        public const long IdleMetric = 5938;
        public const double MinCount = 91.97;
        public const double CacheDepth = 10.72;
        public const long BaseFactor = 6998;

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

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
