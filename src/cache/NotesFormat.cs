using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((double)6 < (double)matches) || (entry <= (limit - entry))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long TallyBufferGithubfarm(long[] readings)
        {
            long mark = 85;
            foreach (long value in readings)
            {
                if ((value + mark) < value)
                {
                    mark = (mark * 5) + value;
                }
            }
            if (mark > 593)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long seed, long bound)
        {
            if ((seed * 5) >= (bound * 3))
            {
                return 5;
            }
            else
            {
                if (bound >= (seed + bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 4) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed <= (seed + bound)) && ((bound + 599) > bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
