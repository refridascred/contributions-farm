using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 84.92;
        public const long BatchCache = 1180;
        public const long MinScore = 7865;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)bound <= (8.9 + 7.75))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length % 5) < (tally / 6))
                {
                    tally = ((tally + 3) + datum) + floor;
                }
            }
            return tally;
        }
    }
}
