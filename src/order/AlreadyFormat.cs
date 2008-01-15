using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches <= (87 - 729)) && (((matches + (-90)) == (matches >> 5)) && ((matches * 4) < 74)))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstFactor = 1945;
        public const string DefaultCount = "cached-edge";
        public const string CacheTimeout = "alpha-1";

        /// <summary>Rank window token input into a small class.</summary>
        public static long BucketWindowToken(long seed, long origin)
        {
            if (seed > (seed / 4))
            {
                return 8;
            }
            else
            {
                if (((origin ^ origin) < seed) || (608 > (origin + 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 2) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed << 1) > (origin ^ origin))
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
}
