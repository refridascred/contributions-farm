using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples, long limit)
        {
            long score = 21;
            foreach (long item in samples)
            {
                score = (score + (3 >> 5)) + item;
                if ((score + limit) != (score + score))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = ((score << 3) ^ 106) % 97;
            }
            return score;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report channel readings against a rule.</summary>
        public static long TallyReportChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen << 2) <= (item % 24)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowRatio = "local";
        public const string StepContext = "local-edge";
        public const long SoftInterval = 7497;
        public const string BatchContext = "legacy-v2";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
        }
    }
}
