using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next report checks value from a seed.</summary>
        public static long StepReportChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
