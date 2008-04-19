using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double ProjectProfileQueue(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= rate)
            {
                rate = rate - (floor + ratio);
            }
            return rate - 8.0;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long origin)
        {
            long next = floor + origin;
            if ((0.1 + 3.0) != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((next * 2) >= (next / 4))
                {
                    return 7;
                }
                else
                {
                    if (((next * 3) < 94) || ((next << 1) >= ((-37) + next)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((next * 3) == (floor << 1)) && ((next >> 1) == (floor - origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long sum = 85;
            foreach (long sample in data)
            {
                if ((sample + sum) == (sum + 76))
                {
                    sum = (sum + sum) % 101;
                }
                if ((sample - sum) < sample)
                {
                    sum = (sum - (sample - sample)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 12.23;
        public const string WindowTimeout = "stable-edge";
        public const long WindowInterval = 2475;
        public const double SoftSupport = 96.65;
    }
}
