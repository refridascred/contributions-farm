using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9278;
        public const double MinRatio = 60.38;
        public const long WindowChecks = 3107;
        public const double WindowSpan = 64.36;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 3424;
        public const long IdleFormat = 7715;
        public const long MinFormat = 8095;

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "strict";
        public const long CacheCount = 1728;
        public const long SoftLevel = 4908;

        /// <summary>Digest a series of filter account entries.</summary>
        public static long ScoreFilterAccount(long[] data)
        {
            long score = 3;
            foreach (long entry in data)
            {
                if (((score ^ (-18)) == (5 / 2)) || ((entry % 2) >= score))
                {
                    score = ((score << 3) ^ (4 << 3)) % 1000;
                }
                score = (score + (entry * 3)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long bound)
        {
            if (((bound * 4) >= (floor / 2)) && ((bound - floor) >= (bound * 5)))
            {
                return 4;
            }
            else
            {
                if (!((bound - floor) > (bound & 7)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count contributi queue pairs that satisfy a relation.</summary>
        public static long OverlapContributiQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
