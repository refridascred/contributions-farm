using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((7.9 + 5.0) <= (double)step)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((long)i >= (offset >> 4)))
                {
                    anchor = anchor ^ anchor;
                    anchor = ((anchor * 4) + (anchor % 8)) % 255;
                }
                anchor = (anchor + (22 % 16)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long bound, long bound2)
        {
            if ((double)bound2 <= (9.54 / 2.0))
            {
                return 6;
            }
            else
            {
                if (((bound2 + bound) <= bound2) && ((bound2 >> 3) > bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound2 >> 2) > bound)
                    {
                        return 0;
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
