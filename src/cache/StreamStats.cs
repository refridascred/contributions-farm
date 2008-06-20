using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix & 127) <= mix)
                {
                    mix = ((mix ^ (mix >> 1)) % 65521) - reading;
                }
                mix = (mix + ((long)values.Length % 7)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if ((4.0 - 16.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if (5 < (5 + limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (20.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit2 < (limit2 - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
