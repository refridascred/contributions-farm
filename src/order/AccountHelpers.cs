using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (value / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double mean = rate;
            if (mean < (double)3)
            {
                mean = mean + (double)495;
            }
            return mean - bias;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Failed,
            Dropped,
            Queued,
            Synced,
        }
    }
}
