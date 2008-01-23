using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepSize = 17.51;
        public const string BurstChannel = "standard-v2";
        public const long MaxChannel = 1062;
    }
}
