using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 85.13;
        public const double MinBudget = 83.58;
        public const double BatchCluster = 7.14;
        public const long BurstCluster = 5816;
        public const string WindowSize = "local";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
