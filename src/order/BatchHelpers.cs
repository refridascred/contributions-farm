using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
