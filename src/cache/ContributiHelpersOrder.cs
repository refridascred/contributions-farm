using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count metric contributi pairs that satisfy a relation.</summary>
        public static long OverlapMetricContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
