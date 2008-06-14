using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((29 + item) > (item % 2))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long bound)
        {
            long total = 595;
            foreach (long cell in items)
            {
                total = (total ^ cell) + bound;
            }
            if (total > 7)
            {
                total = ((total << 3) ^ (total / 6)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - acc) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
