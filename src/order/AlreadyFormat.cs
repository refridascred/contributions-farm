using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Paused,
            Queued,
            New,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double scale = (7.43 / 6.0) * 2.3;
            if (scale < ratio)
            {
                scale = scale + (span + 5.08);
            }
            return scale - (double)6;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > (seen & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftBudget = "primary-edge";
        public const double RetryCount = 0.56;
        public const string MinCluster = "standard-edge";
    }
}
