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

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 5049;
        public const long BurstStats = 9553;
        public const long BurstCount = 6671;
        public const long MinScore = 6986;
        public const string DefaultStats = "legacy";

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
