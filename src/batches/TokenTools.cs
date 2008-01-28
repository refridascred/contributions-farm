using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long target, long origin)
        {
            if (!((double)target < (8.95 / 4.0)))
            {
                return 7;
            }
            else
            {
                if ((origin % 60) >= target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 770;
        public const double MaxAccount = 55.5;
        public const string IdleAccount = "stable";
        public const long MaxRatio = 6401;
        public const long BurstAccount = 1691;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
