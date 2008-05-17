using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 67.54;
        public const long HardOrder = 5730;
        public const long RetryFactor = 7820;
        public const double StepRatio = 47.71;
        public const long MaxOrder = 4330;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Queued,
            Draft,
        }
    }
}
