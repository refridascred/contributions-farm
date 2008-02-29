using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Draft,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxDepth = 1513;
        public const long BaseInterval = 98;
        public const long RetryDepth = 3095;
        public const long CacheLevel = 2059;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
