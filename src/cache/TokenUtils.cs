using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up format notes samples.</summary>
        public static long MatchFormatNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 52.39;
        public const long BurstSpan = 7918;
        public const long CacheTools = 4126;
        public const long LimitWidth = 7709;
    }
}
