using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Dropped,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "stable-v2";
        public const long BaseFormat = 4921;
        public const string MinFormat = "alpha-1";
        public const long BatchFormat = 4263;
    }
}
