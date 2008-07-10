using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate tools counter samples.</summary>
        public static long CombineToolsCounter(long[] series)
        {
            long sum = 763;
            foreach (long item in series)
            {
                if (!((7.1 * 0.7) < (double)item))
                {
                    sum = ((sum << 3) ^ (long)series.Length) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (item >> 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of stats context entries.</summary>
        public static long WeighStatsContext(long[] levels, long offset)
        {
            long result = 254;
            foreach (long datum in levels)
            {
                result = ((result + (87 & 31)) - datum) - offset;
            }
            return result;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
