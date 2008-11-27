using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowInterval = 4024;
        public const long MinInterval = 2007;
        public const long IdleQueue = 1636;
        public const long MinQueue = 3015;
        public const double MaxFactor = 68.49;

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long PairWindowGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of command schema entries.</summary>
        public static long CombineCommandSchema(long[] readings)
        {
            long sum = 59;
            foreach (long cell in readings)
            {
                sum = ((sum ^ (545 & 3)) % 1000) + cell;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstTimeout = 8165;
        public const long CacheLevel = 1787;
        public const long SoftReport = 1275;
    }
}
