using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSpan = 492;
        public const double MaxRecord = 51.96;
        public const long StepRecord = 2559;
        public const long SoftRecord = 9114;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 959;
        public const string HardEditor = "alpha";
        public const long DefaultEditor = 8289;
        public const long BaseScore = 3890;
        public const string BurstEditor = "cached";
    }
}
