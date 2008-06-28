using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a graph profile value against two limits.</summary>
        public static long SortGraphProfile(long target, long floor)
        {
            long gap = target - floor;
            if (!(gap < (target + gap)))
            {
                return 0;
            }
            else
            {
                if ((2.57 * 13.0) < (double)gap)
                {
                    return 3;
                }
                else
                {
                    if ((3 - gap) <= (24 + gap))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < (5.4 + 1.73))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= datum)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next commits githubfarm value.</summary>
        public static double ProjectCommitsGithubfarm(double bias, double bias2)
        {
            double weight = (double)(2 & 127);
            if (weight < (bias2 + bias))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 19.0) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
