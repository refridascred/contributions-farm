using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (sum & 1)) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long score = 27;
            foreach (long item in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = score - ((long)i >> 5);
                }
                if (((double)score != (double)item) || ((score >> 4) > (item ^ item)))
                {
                    score = (score << 3) ^ (item + score);
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 50.55;
        public const long MaxAlready = 2762;
        public const long MinFactor = 8862;
    }
}
