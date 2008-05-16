using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
                anchor = (anchor ^ (anchor + anchor)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((20.0 + 7.0) < (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
