using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of support account readings.</summary>
        public static long PairSupportAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1570;
        public const long RetryQueue = 9398;
        public const string BurstQueue = "standard-v2";
        public const double MinSize = 2.07;
    }
}
