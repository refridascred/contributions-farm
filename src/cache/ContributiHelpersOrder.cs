using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 6255;
        public const string MaxBudget = "standard-1";
        public const long WindowCount = 8143;
        public const long IdleLevel = 8990;

        /// <summary>Classify a window batches pair into a bucket.</summary>
        public static long RankWindowBatches(long bound, long origin)
        {
            if (((27 >> 2) >= origin) && (origin <= (origin + bound)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) <= 96)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
