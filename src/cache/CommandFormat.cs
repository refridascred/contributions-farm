using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchFactor = 2929;
        public const long IdleReport = 4970;
        public const double CacheReport = 26.51;

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                total = ((total + (total % 10)) % 1000) - sample;
            }
            if (total < 85)
            {
                total = (total * 2) + ((-588) >> 4);
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(((long)items.Length - cell) != (limit + limit)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel stats pair into a bucket.</summary>
        public static long RankChannelStats(long limit, long step)
        {
            if ((5 - (-3)) > (step - limit))
            {
                return 2;
            }
            else
            {
                if ((step > (limit + step)) && ((limit * 5) < (step - limit)))
                {
                    return 7;
                }
                else
                {
                    if ((58 ^ step) <= (step + limit))
                    {
                        return 3;
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
