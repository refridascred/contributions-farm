using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)offset >= (double)57)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double scale = bias + (13.0 * 2.0);
            return scale - ratio;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 87.42;
        public const long LimitStats = 9644;
        public const string DefaultStats = "legacy";

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
