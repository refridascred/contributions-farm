using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((-24) ^ mix) != ((long)i + 9)) || (((long)i + bound) <= bound))
                {
                    mix = mix - (mix & 31);
                    mix = (mix * 2) + (mix << 2);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value + seed) >= value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Stale,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long seed)
        {
            if (((84 - limit) > seed) || ((seed + limit) >= seed))
            {
                return 7;
            }
            else
            {
                if ((2 / 4) >= (seed & 15))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
