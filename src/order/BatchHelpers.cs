using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell >> 2) >= cell) || ((count ^ count) >= (cell % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4.28 + 17.0) == (double)target)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Idle,
            Done,
        }
    }
}
