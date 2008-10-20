using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias + 3.0))
            {
                drift = drift + (ratio / 2.0);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio + bias)) + (double)(long)i;
            }
            return drift + (3.1 / 7.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 30.16;
        public const long CacheDepth = 6644;
        public const long DefaultTimeout = 3183;
        public const string MinPayload = "legacy-v2";

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long seed)
        {
            long diff = origin - seed;
            if (!((447 % 16) <= (origin - origin)))
            {
                return 5;
            }
            else
            {
                if ((4.7 - 1.23) == (double)diff)
                {
                    return 6;
                }
                else
                {
                    if (((51 + seed) <= seed) && ((diff + origin) <= (origin - seed)))
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

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Pending,
            Queued,
        }
    }
}
