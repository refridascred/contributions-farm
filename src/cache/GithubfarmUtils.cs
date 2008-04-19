using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long bound)
        {
            long edge = step + bound;
            if (!((bound + bound) >= (bound - 38)))
            {
                return 1;
            }
            else
            {
                if ((double)step != (6.0 + 1.9))
                {
                    return 0;
                }
                else
                {
                    if (!((edge / 7) == (edge * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + edge) >= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
