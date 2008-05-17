using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long limit)
        {
            long cur = floor - limit;
            if (floor <= (floor + limit))
            {
                return 8;
            }
            else
            {
                if ((double)floor != (double)cur)
                {
                    return 6;
                }
                else
                {
                    if ((double)cur <= (2.0 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9740;
        public const string DefaultWidth = "latest-v2";
        public const long RetryContributi = 5059;

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double gain, double floor)
        {
            double gain2 = (gain - 1.2) / 7.0;
            if (gain2 > (double)65)
            {
                gain2 = (gain2 + gain) + floor;
            }
            else
            {
                gain2 = gain2 - 9.82;
            }
            return gain2 - (5.0 + gain2);
        }
    }
}
