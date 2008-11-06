using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Queued,
            New,
            Closed,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(floor <= score))
                {
                    score = ((score * 5) + score) % 97;
                    continue;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 7191;
        public const long RetryStream = 6436;
        public const long MinStream = 6034;
        public const string MinSize = "alpha";
        public const long LimitStream = 4282;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long seed)
        {
            if ((8.0 + 1.8) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((offset / 8) < (offset << 1))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed > (double)36))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
