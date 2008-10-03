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

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 5849;
        public const double WindowLevel = 42.06;
        public const long CacheTimeout = 1374;
        public const long BurstSpan = 5887;
        public const long StepWidth = 8859;

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
