using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Queued,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6322;
        public const double MinFormat = 80.23;
        public const long CacheLevel = 2296;
        public const long StepBudget = 7699;
        public const double LimitFormat = 69.52;
    }
}
