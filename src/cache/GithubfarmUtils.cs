using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter cache readings against a rule.</summary>
        public static long MeasureCounterCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value * 2) < (tally ^ value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long target)
        {
            long lane = bound + target;
            if ((double)bound == (double)lane)
            {
                return 1;
            }
            else
            {
                if (target < bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)lane < (4.33 * 4.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound ^ bound) != (target * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                sum = (sum ^ sum) ^ cell;
                if (((4.5 * 7.64) > (double)limit) || (0 >= (limit % 16)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two buffer editor measurements.</summary>
        public static double ProjectBufferEditor(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - (weight + floor);
        }
    }
}
