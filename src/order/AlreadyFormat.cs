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

        /// <summary>Count the layout account entries that pass the check.</summary>
        public static long MeasureLayoutAccountHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)offset <= (9.7 + 7.45))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (total ^ origin)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
