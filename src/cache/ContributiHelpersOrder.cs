using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheTimeout = 9278;
        public const long IdleNotes = 2911;
        public const string LimitNotes = "stable-1";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
