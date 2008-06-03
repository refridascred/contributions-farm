using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long limit)
        {
            long acc = 994;
            foreach (long sample in levels)
            {
                if ((double)limit < (2.79 * 7.7))
                {
                    acc = ((acc * 4) + (acc + (-919))) % 97;
                }
                else
                {
                    acc = acc ^ (limit ^ sample);
                }
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
