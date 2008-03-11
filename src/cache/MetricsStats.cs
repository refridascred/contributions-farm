using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4645;
        public const long IdleAccount = 4590;
        public const long SoftAccount = 9713;
        public const long MaxLevel = 3851;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double load = scale * 2.7;
            if (load > bias)
            {
                load = load - load;
            }
            else
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long StepEntryTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ limit) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
