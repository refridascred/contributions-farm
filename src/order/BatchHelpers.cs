using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count command report pairs that satisfy a relation.</summary>
        public static long OverlapCommandReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a profile record pair into a bucket.</summary>
        public static long RankProfileRecord(long target, long seed)
        {
            long edge = target ^ seed;
            if ((7 - edge) > 34)
            {
                return 1;
            }
            else
            {
                if ((target + target) >= (edge / 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((586 - limit) <= (517 & 255))
            {
                return 0;
            }
            else
            {
                if (limit > (origin * 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
