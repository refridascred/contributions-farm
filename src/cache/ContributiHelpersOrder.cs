using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 1056;
        public const string IdleDepth = "legacy-edge";
        public const long StepLevel = 6077;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Idle,
            Queued,
            Locked,
        }
    }
}
