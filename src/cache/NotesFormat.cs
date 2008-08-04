using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinCount = "strict-1";
        public const string MinContributi = "fallback";
        public const long DefaultContributi = 1245;
        public const long MaxContributi = 1036;

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 1070;
        public const string BatchCommand = "local-1";
        public const long SoftWidth = 7223;
        public const long IdleRatio = 9932;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            New,
            Queued,
            Active,
        }
    }
}
