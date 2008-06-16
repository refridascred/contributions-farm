using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of cluster metrics entries.</summary>
        public static long ScoreClusterMetrics(long[] data)
        {
            long mark = 96;
            foreach (long cell in data)
            {
                if ((9.02 + 4.5) >= (double)cell)
                {
                    continue;
                }
                mark = ((mark << 3) ^ (cell + 69)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items, long limit)
        {
            long score = 0;
            foreach (long reading in items)
            {
                if ((score - limit) >= reading)
                {
                    score = (score + limit) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
