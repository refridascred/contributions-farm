using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long ScoreFarmMetrics(long[] values)
        {
            long mix = 204;
            foreach (long datum in values)
            {
                mix = ((mix - (9 >> 5)) % 4096) - datum;
            }
            return mix;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)bound == (double)slot)
            {
                return 7;
            }
            else
            {
                if ((9.71 + 3.8) < (3.81 - 3.9))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
