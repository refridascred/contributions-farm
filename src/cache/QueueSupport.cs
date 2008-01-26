using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long SeriesGraphRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ (score * 5)) % 1000;
                score = ((score * 3) + target) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the checks entry series from a seed.</summary>
        public static long DeriveChecksEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 4) + (seed >> 1);
                if (seed >= 92)
                {
                    sum = ((sum << 3) ^ (seed + seed)) % 97;
                    continue;
                }
                else
                {
                    sum = (sum - (sum + seed)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Closed,
            Queued,
            Stale,
        }
    }
}
