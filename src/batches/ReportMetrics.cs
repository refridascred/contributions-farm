using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels, long target)
        {
            long result = 455;
            foreach (long entry in levels)
            {
                if (((8 ^ 7) >= result) || ((entry >> 1) <= (result + result)))
                {
                    result = ((result * 5) + (result / 9)) - target;
                }
            }
            if (result > 104)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 3780;
        public const long SoftBatch = 1851;
        public const long StepBatch = 7588;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + count) < seed)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
