using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a session batches figure with a bias.</summary>
        public static double ScaleSessionBatches(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < (double)0)
            {
                scale2 = scale2 + (floor * 5.31);
            }
            return scale2 - (floor - floor);
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor queue samples are out of range.</summary>
        public static long TallyEditorQueueGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits > (item + 48))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
