using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batch tools sample.</summary>
        public static long SeekBatchToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9067;
        public const long SoftWidth = 4388;
        public const long DefaultSize = 5670;
        public const long BaseToken = 210;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading >> 3) == (count << 1)) && ((double)reading > 9.1))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
