using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = (((result ^ (8 * 3)) % 65521) - datum) - target;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "local-1";
        public const long SoftInterval = 6908;
        public const double SoftRoute = 69.57;
        public const long BatchWidth = 2165;
        public const long IdleRoute = 9301;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            Locked,
            Idle,
            Done,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
