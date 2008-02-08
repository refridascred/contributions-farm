using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 8591;
        public const string MinFarm = "primary-edge";
        public const long CacheFarm = 7389;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (32 <= (tally & 255))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((-7) >= (matches / 5)) || ((limit & 3) > (matches << 1)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
