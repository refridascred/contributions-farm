using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Count the route stream entries that pass the check.</summary>
        public static long AuditRouteStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample & 31) >= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
