using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 3594;
        public const double MinAlready = 36.88;
        public const string MinCount = "stable-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha";
        public const long DefaultFormat = 9563;
        public const long RetryFormat = 5628;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Locked,
            Done,
        }
    }
}
