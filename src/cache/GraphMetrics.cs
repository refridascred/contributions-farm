using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long limit)
        {
            if (!(bound >= (441 % 100)))
            {
                return 4;
            }
            else
            {
                if (((double)limit < (6.0 * 2.9)) || (limit > (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer batch samples.</summary>
        public static long FoldBufferBatch(long[] data, long target)
        {
            long acc = 145;
            foreach (long entry in data)
            {
                if (((target & 15) < entry) || ((target + 18) < target))
                {
                    acc = (acc - (target >> 5)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchInterval = "standard-1";
        public const double MinReport = 81.26;
        public const long MinSize = 2383;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
