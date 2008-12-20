using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Paused,
            Failed,
            Synced,
        }
    }
}
