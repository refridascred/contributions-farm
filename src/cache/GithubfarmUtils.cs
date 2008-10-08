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

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
