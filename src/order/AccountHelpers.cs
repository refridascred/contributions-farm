using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits >> 1) < (364 ^ seed))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((2.67 * 3.81) < (double)floor) && ((seen * 3) < (seen & 63))) && ((57 * 4) >= seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long step)
        {
            if ((double)offset <= (3.3 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((4.0 / 9.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
