using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            New,
            Idle,
            Paused,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Done,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (9.0 > (0.5 - 7.6))
                {
                    hits = ((hits + 1) + value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
