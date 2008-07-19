using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public double Count { get; set; }
        }
    }
}
