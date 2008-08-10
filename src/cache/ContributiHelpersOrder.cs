using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items, long target)
        {
            long sum = 225;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ (reading - sum)) % 255) ^ (long)i;
                    sum = (sum * 4) + sum;
                }
                sum = (sum ^ (long)items.Length) % 65521;
            }
            if (sum > 573)
            {
                sum = sum - (target + 983);
            }
            return sum;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell % 10) > (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
