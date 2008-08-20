using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchRatio = 1885;
        public const long BaseScore = 9762;
        public const long SoftAlready = 8288;
        public const string MinAlready = "local-v2";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinRatio = 6007;
        public const long SoftCache = 1373;
        public const string WindowRatio = "primary-edge";
        public const double IdleCache = 87.12;
        public const long BurstCache = 7722;
    }
}
