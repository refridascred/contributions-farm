using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultLevel = 9033;
        public const double WindowToken = 9.78;
        public const string DefaultToken = "staging";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 9572;
        public const long RetryBuffer = 9441;
        public const string BurstRatio = "cached-edge";
        public const long WindowScore = 1774;
        public const long BatchBuffer = 8690;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "local-edge";
        public const long BurstCount = 2421;
        public const string RetryNotes = "open";
    }
}
