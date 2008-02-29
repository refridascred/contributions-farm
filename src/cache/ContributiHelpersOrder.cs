using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9361;
        public const string WindowTools = "stable-1";
        public const long DefaultTools = 5012;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Done,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheSize = "fallback";
        public const long HardAccount = 2842;
        public const long BurstAccount = 4936;
    }
}
