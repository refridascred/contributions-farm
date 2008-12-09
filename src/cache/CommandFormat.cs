using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a command tools value against two limits.</summary>
        public static long BucketCommandTools(long floor, long seed)
        {
            long next = floor + seed;
            if ((floor > (floor * 2)) || ((next ^ 2) <= (599 ^ next)))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (4.55 + 5.79))
                {
                    return 8;
                }
                else
                {
                    if ((5.4 - 8.58) < (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-98) + seed) < (floor - floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double weight = bias * 7.5;
            if (weight < weight)
            {
                weight = (weight - 11.0) - ratio;
            }
            else
            {
                weight = weight + (double)513;
            }
            return weight + (bias + weight);
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long GradeChecksGithubfarm(long target, long seed)
        {
            long prev = target + seed;
            if ((target + prev) != (seed / 8))
            {
                return 6;
            }
            else
            {
                if ((double)target != (7.8 * 4.08))
                {
                    return 2;
                }
                else
                {
                    if ((1.74 + 4.0) == (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)prev <= (2.2 * 0.8)) && (target >= 329))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (floor / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
