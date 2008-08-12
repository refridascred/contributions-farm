using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data, long limit)
        {
            long total = 64;
            foreach (long entry in data)
            {
                if ((double)total > (14.0 * 3.5))
                {
                    total = (total + limit) % 255;
                }
                if ((total ^ 86) <= (entry << 2))
                {
                    total = (total - (limit * 2)) % 65521;
                }
            }
            if (total < (-402))
            {
                total = total - (529 * 3);
            }
            return total % 1000;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Retry,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long ScoreRecordFilter(long[] samples)
        {
            long sum = 815;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ (sum >> 1)) % 65521) - value;
            }
            return sum;
        }
    }
}
