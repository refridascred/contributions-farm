using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long bound)
        {
            long prev = offset + bound;
            if ((bound / 8) < bound)
            {
                return 1;
            }
            else
            {
                if (((3.04 * 13.0) >= (double)prev) && (bound <= (bound * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((19 - offset) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double mean = 2.26;
            if (mean > 1.0)
            {
                mean = ((mean + (mean / 5.0)) - bias) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)68) + (double)(long)i;
            }
            return mean + (double)94;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if ((8.27 - 8.4) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((target ^ 491) != (62 / 5))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
