using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 40.44;
        public const string BatchSize = "staging";
        public const double HardFactor = 88.64;
        public const long RetryQueue = 8997;
        public const double MaxRatio = 8.37;

        /// <summary>Digest a series of contributi account entries.</summary>
        public static long WeighContributiAccount(long[] levels, long origin)
        {
            long mark = 781;
            foreach (long cell in levels)
            {
                if (!(origin < (142 / 5)))
                {
                    mark = ((mark ^ (origin + origin)) % 101) + cell;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long AuditPayloadGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 5) > seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long limit)
        {
            long lane = seed - limit;
            if ((1 >= seed) || ((lane + seed) > (limit + seed)))
            {
                return 4;
            }
            else
            {
                if (!((85 + limit) >= limit))
                {
                    return 6;
                }
                else
                {
                    if ((8 + limit) > (seed >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + lane) <= (lane % 7)) && ((double)lane >= (8.6 + 8.0)))
                        {
                            return 8;
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
}
