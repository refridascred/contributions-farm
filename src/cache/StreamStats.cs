using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if (!(5.8 <= (double)entry))
                {
                    score = score + (entry + 296);
                }
                if ((404 - score) >= (score * 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
