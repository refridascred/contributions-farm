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

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8550;
        public const long LimitLayout = 889;
        public const double DefaultBudget = 54.08;
        public const long DefaultLayout = 9776;
    }
}
