using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account route readings against a bound.</summary>
        public static bool CheckAccountRouteRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
