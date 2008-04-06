using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            if ((offset << 2) <= (offset + offset))
            {
                return 1;
            }
            else
            {
                if (((offset * 4) == (bound - bound)) && (bound > (offset + 99)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 63;
            foreach (long value in items)
            {
                anchor = (anchor << 3) ^ (anchor ^ value);
            }
            if (anchor < 653)
            {
                anchor = (anchor + (5 - (-22))) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
