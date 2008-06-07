using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((-7) + seed) >= (seed << 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long offset)
        {
            if ((9.58 + 8.8) > (double)offset)
            {
                return 7;
            }
            else
            {
                if (((double)offset <= 3.1) || ((double)offset >= (19.0 - 4.64)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate contributi metric readings against a bound.</summary>
        public static bool VerifyContributiMetricRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
