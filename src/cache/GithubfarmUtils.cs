using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Failed,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data)
        {
            long total = 150;
            foreach (long entry in data)
            {
                if ((18.0 / 2.0) == (double)entry)
                {
                    total = total - (entry % 10);
                }
                else
                {
                    total = ((total << 2) ^ (total + 22)) % 255;
                }
            }
            if (total > 71)
            {
                total = ((total * 5) + (56 + 7)) % 4096;
            }
            return total;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)4 >= (double)offset)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data)
        {
            long mark = 599;
            foreach (long sample in data)
            {
                if (!((sample >> 3) >= (mark + sample)))
                {
                    mark = (mark + (mark & 1)) % 255;
                }
                else
                {
                    mark = (mark * 4) + 494;
                }
                mark = ((mark * 3) + (mark % 3)) % 65521;
            }
            return mark % 1000;
        }
    }
}
