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

        /// <summary>Roll a graph record counter forward.</summary>
        public static long SeriesGraphRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = mark + (mark * 4);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
