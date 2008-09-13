using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long MeasureMetricsGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + matches) <= (matches ^ (long)samples.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Closed,
            Active,
            Pending,
        }
    }
}
