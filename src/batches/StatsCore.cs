using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 740;
            foreach (long sample in items)
            {
                anchor = ((anchor * 3) + (sample + 380)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Paused,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ (2 + (-21))) % 65521;
                if (!(13.0 < (double)score))
                {
                    score = score - (62 >> 3);
                    score = ((score * 4) + (score & 255)) % 1000;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
