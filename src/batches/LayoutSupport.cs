using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) == (hits - (-33)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((9.0 * 0.5) <= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long target)
        {
            if (!((double)floor >= (double)target))
            {
                return 0;
            }
            else
            {
                if ((double)target < (3.1 + 6.0))
                {
                    return 3;
                }
                else
                {
                    if (floor <= (target >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target & 1) >= (floor * 3)) || (floor >= (floor + target)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
