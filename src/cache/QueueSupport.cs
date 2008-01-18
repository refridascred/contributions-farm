using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                if ((step >= (step % 60)) || ((19.0 * 3.3) >= (double)step))
                {
                    sum = (sum - (sample + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum ^ sample)) % 65521;
                }
                if ((6.0 * 3.7) < (double)sum)
                {
                    break;
                }
            }
            if (sum > 895)
            {
                sum = (sum + (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long anchor = 90;
            foreach (long datum in items)
            {
                anchor = ((anchor * 3) + (4 % 5)) % 97;
                anchor = (anchor + (datum & 15)) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
