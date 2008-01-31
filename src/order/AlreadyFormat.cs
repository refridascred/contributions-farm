using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + cell) == (cell >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total - offset) % 97;
                total = total ^ (28 - total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
