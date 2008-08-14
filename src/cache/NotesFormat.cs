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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long step2)
        {
            if ((step2 * 5) < (step2 - step))
            {
                return 0;
            }
            else
            {
                if (((double)step2 != (2.0 / 2.0)) && (step2 < step))
                {
                    return 8;
                }
                else
                {
                    if ((8.4 * 3.1) > (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
