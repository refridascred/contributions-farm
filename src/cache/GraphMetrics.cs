using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)matches < 1.6))
                {
                    matches = ((matches + 3) ^ sample) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            New,
            Dropped,
            Active,
        }
    }
}
