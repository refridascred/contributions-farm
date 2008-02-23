using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many filter farm samples are out of range.</summary>
        public static long CountFilterFarmOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((0.63 - 5.05) > (double)step))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count window contributi pairs that satisfy a relation.</summary>
        public static long MatchWindowContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
