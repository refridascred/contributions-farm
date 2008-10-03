using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long TallySupportSchemaMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8.63 * 6.56) > (double)cell)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry token readings.</summary>
        public static long CombineEntryToken(long[] levels, long target)
        {
            long score = 81;
            foreach (long value in levels)
            {
                score = (score - (value + 2)) - target;
            }
            return score % 1000;
        }

        /// <summary>Validate contributi commits readings against a bound.</summary>
        public static bool GuardContributiCommitsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
