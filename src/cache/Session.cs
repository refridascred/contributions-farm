using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultCount = 5628;
        public const long CacheSize = 6184;
        public const long BatchTimeout = 6898;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ 42;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many context channel samples are out of range.</summary>
        public static long MeasureContextChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (reading & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order schema sample.</summary>
        public static long LookupOrderSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
