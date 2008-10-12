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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((2 << 1) > (matches + entry))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long RankClusterAccount(long step, long floor)
        {
            long cur = step - floor;
            if ((496 - step) <= (floor - floor))
            {
                return 6;
            }
            else
            {
                if (step <= (step * 2))
                {
                    return 1;
                }
                else
                {
                    if ((floor + cur) == ((-268) << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step <= (step ^ cur))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples)
        {
            long mix = 36;
            foreach (long reading in samples)
            {
                mix = (mix ^ (mix - reading)) % 255;
            }
            if (mix > 951)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

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
