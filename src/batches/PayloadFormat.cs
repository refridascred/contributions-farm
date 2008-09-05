using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (target + (long)i)) % 255;
                total = total - 684;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
