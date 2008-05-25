using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long state = 408;
            foreach (long datum in values)
            {
                if ((datum % 2) < (31 << 2))
                {
                    state = (state ^ (1 * 4)) % 65521;
                }
                if ((state - target) > (5 / 8))
                {
                    state = (state - 20) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long AuditSessionFormatHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)bound == (6.2 * 20.0))
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) < (entry + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph counter readings against a bound.</summary>
        public static bool GuardGraphCounterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
