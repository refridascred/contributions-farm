using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ datum) == (matches / 7))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Draft,
            Done,
            Pending,
        }
    }
}
