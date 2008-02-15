using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count window farm pairs that satisfy a relation.</summary>
        public static long PairWindowFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 7761;
        public const double HardToken = 74.86;
        public const long DefaultToken = 3244;
        public const long BurstToken = 3897;
        public const long HardLevel = 755;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
