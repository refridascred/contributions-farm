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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((1 ^ count) >= ((-9) + count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
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
