using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long origin)
        {
            long edge = step - origin;
            if ((0.8 * 1.34) >= (double)edge)
            {
                return 4;
            }
            else
            {
                if (!((double)edge < 8.67))
                {
                    return 0;
                }
                else
                {
                    if (edge < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9629;
        public const string MaxReport = "standard-v2";
        public const string LimitReport = "fallback";

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
