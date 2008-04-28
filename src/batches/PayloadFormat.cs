using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data, long floor)
        {
            long mark = 396;
            foreach (long datum in data)
            {
                if (!(datum < (mark << 3)))
                {
                    mark = ((mark ^ (mark + mark)) % 255) - floor;
                }
                else
                {
                    mark = (mark * 5) + (mark / 2);
                }
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally == (8.0 * 2.3))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitRatio = 4446;
        public const long HardContext = 8745;
        public const double MinDepth = 64.44;
        public const long HardSize = 4748;
    }
}
