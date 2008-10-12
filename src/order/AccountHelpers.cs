using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySize = 6348;
        public const long CacheContributi = 9919;
        public const long HardContributi = 3828;
        public const long MaxCount = 8235;
        public const double BurstContributi = 24.1;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            if ((double)floor < (4.13 + 17.0))
            {
                return 5;
            }
            else
            {
                if ((83 - 713) > (6 + floor))
                {
                    return 3;
                }
                else
                {
                    if ((seed <= (floor + seed)) && ((seed - seed) != (floor - 955)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)floor > (0.62 + 1.96)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload metrics readings against a rule.</summary>
        public static long TallyPayloadMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((38 + hits) == (hits + hits))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "latest-1";
        public const string BatchFactor = "legacy-1";
        public const long RetrySession = 4453;
        public const long StepInterval = 4885;

        /// <summary>Rank layout cache input into a small class.</summary>
        public static long SortLayoutCache(long origin, long limit)
        {
            if ((0 - origin) < (12 ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= 6.8)
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (limit % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
