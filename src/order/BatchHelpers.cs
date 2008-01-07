using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches ^ cell) < target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((934 << 1) != (reading % 100))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((cell << 3) >= cell) || ((double)cell >= (double)offset)) && ((1.3 + 1.97) < (double)cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
