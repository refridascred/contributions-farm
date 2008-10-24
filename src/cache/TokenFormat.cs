using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data, long bound)
        {
            long total = 0;
            foreach (long datum in data)
            {
                if ((double)total <= (double)bound)
                {
                    total = ((total << 3) ^ (datum * 3)) % 101;
                }
                else
                {
                    total = (total + (31 >> 1)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long target)
        {
            long next = limit - target;
            if ((double)limit > (6.82 + 4.3))
            {
                return 2;
            }
            else
            {
                if ((target + 53) >= (next + 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)next >= 9.6)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Dropped,
            Closed,
            Failed,
            Draft,
        }
    }
}
