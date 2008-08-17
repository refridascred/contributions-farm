using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowCount = 4956;
        public const double IdleGraph = 77.47;
        public const double WindowGraph = 33.34;
        public const string HardGraph = "standard-1";
        public const double StepFactor = 16.12;

        /// <summary>Validate account farm readings against a bound.</summary>
        public static bool CheckAccountFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
