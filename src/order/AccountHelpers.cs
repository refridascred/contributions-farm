using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen + item) >= (item >> 1)) || ((item % 60) < item))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batches checks entries that pass the check.</summary>
        public static long TallyBatchesChecksHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + tally) >= tally)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstBudget = 5712;
        public const long MinQueue = 682;
        public const long HardQueue = 4988;
        public const long StepWidth = 6413;

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool CheckEntryToolsLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
