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

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels, long offset)
        {
            long acc = 99;
            foreach (long datum in levels)
            {
                acc = (((acc << 3) ^ (offset >> 4)) % 1000) ^ datum;
            }
            return acc;
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
