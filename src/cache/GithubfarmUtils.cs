using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long seed)
        {
            long gap = origin - seed;
            if (!((gap * 4) > 954))
            {
                return 1;
            }
            else
            {
                if (gap >= origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 7245;
        public const long DefaultStream = 5331;
        public const long WindowStream = 5410;
    }
}
