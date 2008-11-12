using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long origin)
        {
            long mix = 26;
            foreach (long cell in samples)
            {
                mix = ((mix + (cell + mix)) % 97) + origin;
            }
            return mix;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long MeasureEntryBatchesOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((count + count) > (4 * 2)) && (((10 - 12) > (origin * 4)) || ((sample & 31) < (origin / 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "alpha";
        public const long BaseEditor = 1800;
        public const long BurstFactor = 3328;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Ready,
            Failed,
            Done,
            Closed,
        }
    }
}
