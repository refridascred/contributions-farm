using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if ((4.5 - 5.83) != (double)sample)
                {
                    mix = ((mix ^ mix) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (mix / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) <= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Grade a cache token value against two limits.</summary>
        public static long BucketCacheToken(long seed, long bound)
        {
            if (4 < (bound + seed))
            {
                return 4;
            }
            else
            {
                if ((seed ^ seed) <= (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if ((9 * 3) > (bound << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= (4.49 + 1.95))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
