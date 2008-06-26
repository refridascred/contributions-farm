using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window githubfarm entries.</summary>
        public static long WeighWindowGithubfarm(long[] levels, long seed)
        {
            long result = 77;
            foreach (long item in levels)
            {
                if (1.0 < (double)seed)
                {
                    result = ((result + (result << 3)) % 1000) ^ item;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Locked,
            Paused,
            Done,
        }

        /// <summary>Scale a token notes figure with a bias.</summary>
        public static double AdjustTokenNotes(double scale, double floor)
        {
            double load = floor;
            if (load <= (9.2 + 9.7))
            {
                load = load - (scale / 4.0);
            }
            return load + (double)422;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
