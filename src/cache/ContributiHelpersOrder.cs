using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 5966;
        public const long MaxNotes = 6542;
        public const string BurstNotes = "stable-edge";
        public const long BatchLevel = 6953;
        public const double BaseDepth = 38.69;

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
