using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 9795;
        public const long DefaultRoute = 2708;
        public const long BaseRoute = 8261;

        /// <summary>Accumulate farm batches samples.</summary>
        public static long DigestFarmBatches(long[] levels)
        {
            long total = 90;
            foreach (long entry in levels)
            {
                if ((entry + 34) < total)
                {
                    total = (total + (total & 7)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
