using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long total = 465;
            foreach (long datum in values)
            {
                if ((datum + total) >= (datum + 7))
                {
                    total = total - (total / 8);
                }
            }
            if (total > 458)
            {
                total = ((total * 3) + (total - total)) % 1000;
            }
            return total;
        }

        /// <summary>Match up checks contributi samples.</summary>
        public static long MatchChecksContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((6.5 + 6.8) <= (double)step) || ((6 / 9) > datum)) || !(matches < (matches << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
