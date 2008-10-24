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

        /// <summary>Rank tools account input into a small class.</summary>
        public static long ClassifyToolsAccount(long step, long origin)
        {
            long diff = step - origin;
            if ((step >= diff) && ((double)step > (5.4 * 3.51)))
            {
                return 5;
            }
            else
            {
                if ((step + origin) == (step - origin))
                {
                    return 7;
                }
                else
                {
                    if (4.0 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
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
