using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long carry = 58;
            foreach (long cell in series)
            {
                if (!((cell - cell) >= (34 + cell)))
                {
                    carry = carry - cell;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long limit)
        {
            long prev = target + limit;
            if (((prev + target) <= (target * 3)) || ((double)target <= (16.0 * 9.0)))
            {
                return 7;
            }
            else
            {
                if ((limit > prev) && ((double)target != (5.3 * 4.73)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1205;
        public const string WindowAccount = "alpha";
        public const long LimitAccount = 1289;
        public const long MaxSize = 2239;
        public const string IdleAccount = "staging";

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((sum + 512) > sum) && ((double)floor == (6.0 - 2.9)))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
