using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Idle,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long CountNotesLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 5) > (reading + reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
