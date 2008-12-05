using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((542 / 3) <= (datum >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Idle,
            Draft,
            Synced,
            Ready,
        }
    }
}
