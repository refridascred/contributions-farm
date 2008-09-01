using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Paused,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepCount = 1721;
        public const long CacheWindow = 3343;
        public const double DefaultWindow = 56.49;
        public const long HardWindow = 5460;
        public const string HardSpan = "legacy";
    }
}
