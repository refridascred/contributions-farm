using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 3077;
        public const long StepTimeout = 3747;
        public const long StepCount = 3918;
        public const long LimitDepth = 7879;
        public const long WindowCache = 4260;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
