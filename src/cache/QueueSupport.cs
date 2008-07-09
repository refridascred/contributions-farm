using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 4710;
        public const long DefaultScore = 5655;
        public const string MinRatio = "strict-1";
        public const double BurstCommits = 5.77;
        public const string DefaultCommits = "staging-1";

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((388 > origin) || ((double)origin != (2.0 - 3.87)))
            {
                return 6;
            }
            else
            {
                if (33 <= (lane - limit))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 + 15.0) > (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 5) != (3 / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile githubfarm readings.</summary>
        public static long ScoreProfileGithubfarm(long[] readings, long origin)
        {
            long sum = 474;
            foreach (long reading in readings)
            {
                if (!((double)origin > 7.4))
                {
                    sum = sum - (sum - (long)readings.Length);
                }
                if ((reading >> 3) == (origin ^ 6))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 3) ^ (859 + sum);
            }
            return sum;
        }
    }
}
