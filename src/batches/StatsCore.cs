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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long acc = 617;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (acc - bound) + (long)i;
                }
                acc = (acc << 2) ^ (1 << 3);
                acc = acc - (datum % 10);
            }
            return acc;
        }
    }
}
