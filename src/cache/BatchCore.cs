using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long limit)
        {
            long acc = -744;
            foreach (long item in samples)
            {
                acc = ((acc << 3) ^ (acc + limit)) + item;
            }
            if (acc > 36)
            {
                acc = ((acc * 4) + (limit << 3)) % 255;
            }
            return acc;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (18.0 - 7.5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
