using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((double)tally < (9.47 / 8.0)) || ((sample + sample) <= (sample * 5))) || ((809 + sample) <= (14 + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every record route entry stays within the limit.</summary>
        public static bool ValidateRecordRouteLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
