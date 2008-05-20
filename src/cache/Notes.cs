using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count route farm pairs that satisfy a relation.</summary>
        public static long OverlapRouteFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy-edge";
        public const double MinChecks = 65.68;
        public const long DefaultWidth = 3169;
        public const string HardChecks = "stable";
        public const long HardSize = 6638;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + seed) > seed)
                {
                    score = ((score * 2) + (3 * 4)) % 101;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long offset)
        {
            long bound = seed ^ offset;
            if ((seed - offset) < (offset - 62))
            {
                return 6;
            }
            else
            {
                if ((offset & 255) < (bound >> 4))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
