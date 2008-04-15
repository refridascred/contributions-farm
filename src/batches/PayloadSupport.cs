using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Stale,
            Closed,
        }
    }
}
