using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Dropped,
            New,
            Done,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftInterval = 1750;
        public const long WindowChannel = 874;
        public const string BurstChannel = "legacy-v2";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
