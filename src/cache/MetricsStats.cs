using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ 0) - (long)i2;
                }
                state = (state + ((long)i ^ origin)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry - seen) > ((long)data.Length * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ (75 << 3)) % 255) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Synced,
            Dropped,
            New,
        }
    }
}
