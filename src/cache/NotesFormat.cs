using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 4532;
        public const string SoftToken = "cached";
        public const string BatchToken = "standard-1";
        public const long SoftInterval = 241;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            New,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchBudget = 4801;
        public const double StepInterval = 70.2;
        public const long BatchSpan = 8466;
        public const double BurstChannel = 2.38;
        public const string RetryChannel = "open-1";
    }
}
