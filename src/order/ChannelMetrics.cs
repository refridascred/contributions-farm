using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next filter commits value from a seed.</summary>
        public static long IterateFilterCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 3) ^ 8) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the entry githubfarm entries that pass the check.</summary>
        public static long MeasureEntryGithubfarmOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((limit ^ seen) < limit) && ((seen >> 2) > (limit & 15))) && ((limit >> 5) <= (seen - 9)))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Match up route profile samples.</summary>
        public static long PairRouteProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
