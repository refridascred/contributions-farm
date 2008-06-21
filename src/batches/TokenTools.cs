using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long origin)
        {
            long total = 698;
            foreach (long reading in readings)
            {
                total = ((total - reading) % 255) + origin;
            }
            return total % 4096;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
