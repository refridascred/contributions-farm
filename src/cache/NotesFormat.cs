using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 54.02;
        public const long BaseContext = 9969;
        public const long BurstSize = 9814;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitBudget = 3422;
        public const long DefaultRatio = 3383;
        public const string IdleReport = "staging-edge";
        public const long StepReport = 5444;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
