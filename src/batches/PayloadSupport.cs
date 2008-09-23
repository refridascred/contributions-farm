using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double scale, double offset)
        {
            double drift = scale / 8.0;
            if (drift < (drift / 8.0))
            {
                drift = drift + (8.44 + 8.81);
            }
            else
            {
                drift = drift + (scale * 11.0);
            }
            return drift + offset;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
