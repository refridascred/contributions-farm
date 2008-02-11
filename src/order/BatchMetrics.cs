using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target - 95) <= ((-2) / 6))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long offset)
        {
            long state = 839;
            foreach (long reading in series)
            {
                state = state ^ reading;
            }
            if (state > (-52))
            {
                state = (state ^ (offset % 5)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Idle,
            Pending,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftFactor = "cached-v2";
        public const string BatchMetrics = "local";
        public const long BatchWidth = 3282;
        public const string BaseSize = "legacy-1";

        /// <summary>Scale a profile editor figure with a bias.</summary>
        public static double ProjectProfileEditor(double weight, double bias)
        {
            double mean = bias * 9.4;
            if (mean >= mean)
            {
                mean = (mean + (double)60) + weight;
            }
            return mean + (14.0 * 7.4);
        }
    }
}
