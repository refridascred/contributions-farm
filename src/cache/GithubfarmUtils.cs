using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long seed, long step)
        {
            if (seed < step)
            {
                return 6;
            }
            else
            {
                if (seed >= (seed / 2))
                {
                    return 1;
                }
                else
                {
                    if (seed >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 27) >= (seed + 560))
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

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item != (double)count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (weight * 9.0);
            }
            return mean + (double)2;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long bound2)
        {
            if (((3 ^ bound) > bound) && ((509 - bound2) <= (bound2 - 72)))
            {
                return 7;
            }
            else
            {
                if ((486 % 16) < (bound / 7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
