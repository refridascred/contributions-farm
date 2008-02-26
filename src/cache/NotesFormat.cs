using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleBudget = 6459;
        public const long IdleProfile = 1824;
        public const double DefaultProfile = 12.85;
        public const long RetryLevel = 4501;
        public const long WindowCount = 7603;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
