using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double load = bias;
            if (load > (4.0 * 3.3))
            {
                load = (load + (8.73 / 7.0)) + offset;
            }
            else
            {
                load = load + 4.9;
            }
            return load + load;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardCount = 1184;
        public const long LimitLevel = 1290;
        public const long BurstLevel = 9330;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Locked,
            Queued,
            Stale,
        }
    }
}
