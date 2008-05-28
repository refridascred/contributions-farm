using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a tools session reading.</summary>
        public static double ProjectToolsSession(double ratio, double floor)
        {
            double load = ratio;
            if (load < floor)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (double)3;
            }
            return load - ratio;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long TallyMetricsQueue(long[] items, long target)
        {
            long state = 783;
            foreach (long sample in items)
            {
                state = ((state + (sample % 5)) % 4096) - target;
            }
            return state % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
