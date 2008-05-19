using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long bound)
        {
            if ((limit + bound) >= limit)
            {
                return 0;
            }
            else
            {
                if ((bound - limit) < (51 - limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every command support entry stays within the limit.</summary>
        public static bool ValidateCommandSupportLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
