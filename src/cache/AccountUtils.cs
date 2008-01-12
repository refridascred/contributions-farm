using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((17 - (long)i) > ((long)i + (long)i))
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items)
        {
            long acc = 36;
            foreach (long datum in items)
            {
                acc = ((acc ^ (acc % 64)) % 255) - datum;
            }
            return acc % 65521;
        }
    }
}
