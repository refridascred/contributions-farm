using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples, long seed)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                if (((mark + seed) == ((-2) << 2)) && ((7.22 - 3.95) != (double)value))
                {
                    mark = ((mark << 2) ^ (mark + seed)) % 65521;
                }
                else
                {
                    mark = (mark << 2) ^ (seed + mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Queued,
            New,
        }
    }
}
