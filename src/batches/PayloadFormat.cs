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

        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long AuditPayloadEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((double)matches <= (double)316) && ((value + value) < 0)) && (((6.5 - 7.0) == (double)value) && ((value << 3) >= (55 + (-351)))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
