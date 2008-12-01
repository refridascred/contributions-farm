using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            New,
            Closed,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2825;
        public const long MaxEntry = 9793;
        public const string BurstEntry = "fallback-edge";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
