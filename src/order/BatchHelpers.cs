using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value >> 1) > value)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }
    }
}
