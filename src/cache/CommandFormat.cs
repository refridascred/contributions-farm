using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 39;
            foreach (long sample in data)
            {
                if ((double)state > (double)sample)
                {
                    state = (state - sample) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepTimeout = 56.79;
        public const long BaseFactor = 7515;
        public const long HardLevel = 5924;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
