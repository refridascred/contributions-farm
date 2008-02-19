using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)(long)samples.Length > (2.6 + 2.7)))
                {
                    seen = ((seen + 3) ^ reading) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample >> 5) <= (seen % 8))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((target + entry) <= 74) && ((matches + 65) <= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
