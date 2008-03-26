using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 4057;
        public const long BatchTimeout = 7371;
        public const long LimitLevel = 999;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
