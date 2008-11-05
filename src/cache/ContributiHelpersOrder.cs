using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + mix)) % 97;
                if (((357 % 10) <= mix) && (7.97 < (double)mix))
                {
                    mix = mix ^ (mix - datum);
                }
            }
            return mix % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitFactor = 7792;
        public const string IdleTimeout = "strict";
        public const double MaxContext = 47.37;
        public const long SoftContext = 1973;
        public const long CacheInterval = 2862;
    }
}
