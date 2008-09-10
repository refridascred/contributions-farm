using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ (floor & 255);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long CombineCacheOrder(long[] data, long seed)
        {
            long score = -9;
            foreach (long reading in data)
            {
                if ((seed % 5) <= reading)
                {
                    score = score ^ (seed ^ score);
                }
                else
                {
                    score = score - score;
                }
            }
            return score % 65521;
        }
    }
}
