using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "staging-edge";
        public const double LimitSupport = 35.73;
        public const long WindowWidth = 6843;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Idle,
            Draft,
            Done,
            Closed,
            Ready,
        }
    }
}
