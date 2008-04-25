using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftWidth = "fallback-edge";
        public const long SoftFactor = 3656;
        public const long RetryFilter = 5383;

        /// <summary>Grade a contributi support value against two limits.</summary>
        public static long RankContributiSupport(long target, long floor)
        {
            if (9.9 >= (double)target)
            {
                return 7;
            }
            else
            {
                if (((double)target == (double)floor) && ((target - target) > (target + floor)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)target >= (0.94 * 8.7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor < (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 1009;
        public const long IdleScore = 4466;
        public const string IdleBatches = "latest-edge";
        public const double RetryRatio = 94.32;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
