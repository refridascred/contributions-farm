using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            if ((2.0 + 2.07) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if (origin >= (seed / 9))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a githubfarm farm figure with a bias.</summary>
        public static double SmoothGithubfarmFarm(double ratio, double floor)
        {
            double load = floor + (double)(-216);
            for (int i = 0; i < 5; i++)
            {
                load = (load + (5.7 - load)) - (double)(long)i;
            }
            return load + (ratio - floor);
        }

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool VerifyCommitsFormatBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
