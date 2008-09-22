using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor * 2) + (anchor / 9);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double ratio = 1.67;
            if (ratio > ratio)
            {
                ratio = ((ratio + (ratio + 1.5)) - rate) - offset;
            }
            return ratio + (ratio / 7.0);
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long target, long step)
        {
            if ((step >= (target ^ target)) || ((double)step > (4.74 * 20.0)))
            {
                return 6;
            }
            else
            {
                if ((2.1 + 4.06) > (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (1.0 + 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step == (4.61 * 1.89)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
