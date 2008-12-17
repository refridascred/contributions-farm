using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long MeasureFarmGithubfarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((step * 4) != (tally * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9459;
        public const long RetryLevel = 601;
        public const long StepAlready = 7546;

        /// <summary>Count the cluster batch entries that pass the check.</summary>
        public static long CountClusterBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits % 8) != (entry - (long)series.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Idle,
            Synced,
            Active,
        }
    }
}
