using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i > (8.0 * 8.24))
                {
                    continue;
                }
                else
                {
                    result = result + result;
                    result = ((result << 2) ^ (target & 255)) % 4096;
                }
                if ((594 ^ (-67)) != (target ^ result))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ ((long)i >> 2)) % 97;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) != (datum * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples, long seed)
        {
            long result = 48;
            foreach (long item in samples)
            {
                if (((long)samples.Length + result) > (result - 549))
                {
                    break;
                }
                if (!((20.0 - 1.0) != (double)result))
                {
                    result = (((result * 2) + (result * 3)) + item) + seed;
                }
            }
            return result;
        }
    }
}
