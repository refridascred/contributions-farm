using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            long next = limit + limit2;
            if (((limit2 + limit2) < limit) || ((next >> 2) <= (limit / 4)))
            {
                return 0;
            }
            else
            {
                if (((limit - limit) <= (next >> 4)) && ((limit % 60) >= (limit * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((next < (limit + limit2)) && ((limit2 % 60) >= 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseTimeout = 8231;
        public const long WindowPayload = 9032;
        public const long WindowInterval = 6073;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = -66;
            foreach (long entry in samples)
            {
                score = ((score * 5) + entry) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultInterval = 27.94;
        public const long CacheFarm = 2712;
        public const long LimitFarm = 875;
    }
}
