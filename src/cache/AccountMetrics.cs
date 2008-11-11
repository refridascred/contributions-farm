using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long step2)
        {
            if ((2.0 - 3.5) < (double)step)
            {
                return 1;
            }
            else
            {
                if (!((step & 31) >= (step + step2)))
                {
                    return 3;
                }
                else
                {
                    if ((step2 < step) || ((5.0 / 6.0) == (double)step2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 3511;
        public const long SoftScore = 4307;
        public const long MinCount = 4381;
        public const double SoftChannel = 57.52;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first order cache entry that matches the target.</summary>
        public static long SeekOrderCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
