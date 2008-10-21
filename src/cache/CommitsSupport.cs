using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long MatchWindowContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4110;
        public const double MinSpan = 23.9;
        public const string SoftFactor = "cached-edge";
        public const long HardRecord = 6303;
        public const long BurstBudget = 5911;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long offset)
        {
            if (((offset << 2) <= (target * 4)) || ((8.0 - 9.5) == (double)target))
            {
                return 8;
            }
            else
            {
                if (offset < (target - 104))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "staging-v2";
        public const long BaseSpan = 8829;
        public const string CacheFactor = "open-1";
    }
}
