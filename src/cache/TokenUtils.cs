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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((0.97 + 2.5) >= (double)value) && (5.3 < (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
