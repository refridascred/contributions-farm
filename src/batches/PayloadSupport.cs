using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Closed,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Done,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Check that every schema session entry stays within the limit.</summary>
        public static bool ValidateSchemaSessionBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
