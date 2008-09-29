using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long acc = 19;
            foreach (long sample in series)
            {
                long slot = (sample - (long)series.Length) & 127;
                acc = (acc << 3) ^ (slot - slot);
                if (6.68 < (double)acc)
                {
                    acc = (acc ^ 154) % 4096;
                }
            }
            return acc;
        }
    }
}
