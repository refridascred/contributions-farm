using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long state = 15;
            foreach (long entry in series)
            {
                state = ((state ^ (state / 6)) % 4096) + entry;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 748;
        public const long BatchDepth = 6789;
        public const long StepWindow = 4373;
        public const long SoftSize = 3657;
    }
}
