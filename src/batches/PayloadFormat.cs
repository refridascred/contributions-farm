using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 39.7;
        public const long MaxLevel = 8462;
        public const long WindowTimeout = 1352;
        public const string MaxWidth = "local";

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double scale2 = (double)(11 - 38);
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + scale) + (double)(long)i) + span;
            }
            return scale2 + (double)330;
        }
    }
}
