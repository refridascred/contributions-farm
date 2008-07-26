using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowLevel = 4036;
        public const long LimitCommand = 5849;
        public const string BaseCommand = "cached-v2";
        public const double StepCommand = 27.59;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Stale,
            Pending,
        }
    }
}
