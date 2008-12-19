using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long origin)
        {
            long sum = 11;
            foreach (long entry in readings)
            {
                if (!((double)sum < (9.0 / 3.0)))
                {
                    sum = (sum ^ (sum - (-88))) % 97;
                }
                if ((origin >> 4) <= (entry - origin))
                {
                    sum = (sum + ((-6) >> 3)) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (sum - entry);
                }
            }
            if (sum > (-50))
            {
                sum = (sum << 2) ^ (origin - origin);
            }
            return sum;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9.3 - 6.7) > (double)entry)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }
    }
}
