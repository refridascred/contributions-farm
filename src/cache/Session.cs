using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Stale,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long CountContextWindowOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) > (seed & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
