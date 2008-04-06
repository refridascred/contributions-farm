using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate route batch readings against a bound.</summary>
        public static bool VerifyRouteBatchRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Synced,
            Active,
            Queued,
            Pending,
        }
    }
}
