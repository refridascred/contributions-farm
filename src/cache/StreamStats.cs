using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length != (double)matches)
                {
                    matches = ((matches + 3) - entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Rank window commits input into a small class.</summary>
        public static long BucketWindowCommits(long step, long offset)
        {
            if (((step + offset) < offset) || ((1 / 7) >= offset))
            {
                return 1;
            }
            else
            {
                if ((step + step) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long bound)
        {
            long bound2 = origin - bound;
            if (((double)bound == (8.0 + 1.3)) || ((2.0 - 6.54) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 != (6.3 - 6.25))
                {
                    return 1;
                }
                else
                {
                    if ((9 + origin) <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0 % 24) >= origin) || ((origin >> 2) < (284 * 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
