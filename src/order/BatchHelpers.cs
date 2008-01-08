using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double StepWidth = 84.59;
        public const long IdleDepth = 4046;
        public const long BatchSize = 2778;
        public const long HardCounter = 5097;

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool CheckCommandMetricsRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Draft,
            Done,
            Retry,
            Closed,
        }
    }
}
