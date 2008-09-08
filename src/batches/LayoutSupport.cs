using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((8.2 + 2.9) > (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Draft,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Dropped,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
