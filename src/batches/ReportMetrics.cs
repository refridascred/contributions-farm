using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long origin)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                if ((entry <= (mix + mix)) || (origin < (entry - entry)))
                {
                    mix = (mix << 3) ^ (29 + entry);
                }
                else
                {
                    mix = ((mix * 2) + 9) % 65521;
                }
            }
            return mix;
        }
    }
}
