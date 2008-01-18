using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double bias, double span)
        {
            double scale = 9.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - span;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultTimeout = 4425;
        public const long BaseSize = 3775;
        public const double LimitBatches = 62.15;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (reading - 405))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Ready,
            Done,
            Draft,
            Queued,
        }
    }
}
