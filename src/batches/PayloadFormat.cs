using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double bias)
        {
            double weight = (double)630 * 3.0;
            return ((weight - weight) + scale) + bias;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((6 / 8) < (seen & 31)) && (((reading / 2) == (3 - 165)) || ((16 + target) < 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Locked,
            Queued,
            Synced,
        }
    }
}
