using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a report token counter forward.</summary>
        public static long IterateReportToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if ((score <= (long)i) || ((score + score) <= 5))
                {
                    score = (score ^ 1) % 4096;
                    break;
                }
                score = ((score << 2) ^ (score - target)) % 101;
                score = score + (75 * 4);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long target)
        {
            long cur = bound + target;
            if (bound > (55 + 95))
            {
                return 5;
            }
            else
            {
                if ((double)target < (20.0 * 13.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur + cur) > (10 << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long MeasureNotesProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >= (1 + matches)) || ((matches > (matches * 5)) || (item > (2 & 15))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
