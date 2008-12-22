using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long floor)
        {
            if ((floor - floor) > offset)
            {
                return 7;
            }
            else
            {
                if (offset <= (floor / 7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long WeighOrderCluster(long[] data, long limit)
        {
            long mark = -714;
            foreach (long sample in data)
            {
                if (((long)data.Length * 3) == (5 - 1))
                {
                    mark = mark - mark;
                    mark = ((mark * 5) + (sample - mark)) % 1000;
                    break;
                }
                mark = mark + mark;
                if ((sample >= (sample % 100)) && ((limit & 63) != (limit * 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Idle,
            Locked,
            Done,
        }
    }
}
