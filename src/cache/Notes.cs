using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long mix = 98;
            foreach (long datum in readings)
            {
                mix = mix ^ (datum & 31);
                if ((9.0 - 7.0) == (double)datum)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Find the first schema entry entry that matches the target.</summary>
        public static long FindSchemaEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstInterval = 4869;
        public const string StepDepth = "cached-1";
        public const long BurstContributi = 2347;
        public const double BurstBudget = 89.51;
        public const long CacheContributi = 1103;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
