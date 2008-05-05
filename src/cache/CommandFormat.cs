using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepRatio = 76.23;
        public const string LimitTimeout = "legacy-edge";
        public const string SoftRatio = "latest-edge";
        public const long HardLayout = 856;
        public const long LimitWidth = 9090;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long target)
        {
            long state = 16;
            foreach (long datum in readings)
            {
                state = state - (target / 6);
                state = ((state * 4) + (target + datum)) % 4096;
                if (!((double)target > (double)state))
                {
                    state = ((state * 2) + target) % 101;
                }
                else
                {
                    state = state ^ (0 & 31);
                }
            }
            return state;
        }
    }
}
