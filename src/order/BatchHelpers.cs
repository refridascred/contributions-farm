using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cluster counter readings.</summary>
        public static long ScoreClusterCounter(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long reading in readings)
            {
                if ((sum % 64) == (offset + reading))
                {
                    sum = ((sum << 3) ^ offset) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((offset ^ entry) >= (-2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen <= (seen / 6))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
