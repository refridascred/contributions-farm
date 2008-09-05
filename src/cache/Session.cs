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

        /// <summary>Define session limits and defaults.</summary>
        public const string StepFactor = "legacy-edge";
        public const double MinSession = 86.61;
        public const long HardRatio = 6209;

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
