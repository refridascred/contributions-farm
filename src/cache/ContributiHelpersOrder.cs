using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine githubfarm window values into a single score.</summary>
        public static long ScoreGithubfarmWindow(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if ((14.0 > (double)total) || ((total / 7) > (total % 2)))
                {
                    total = (total ^ (total % 12)) % 65521;
                    total = (total - datum) % 255;
                    break;
                }
                total = total + (total - datum);
            }
            return total % 4096;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (anchor / 6)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate schema contributi readings against a bound.</summary>
        public static bool CheckSchemaContributiBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
