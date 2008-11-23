using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double gain = offset * 1.8;
            if (gain <= gain)
            {
                gain = (gain - (double)4) - rate;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)47;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardInterval = 79.59;
        public const string BatchTools = "standard-v2";
        public const long MaxTools = 7850;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepBudget = "local-1";
        public const double LimitGithubfarm = 23.21;
        public const long WindowGithubfarm = 5456;
        public const string HardGithubfarm = "stable-1";
        public const double BaseGithubfarm = 20.4;

        /// <summary>Digest a series of order checks entries.</summary>
        public static long DigestOrderChecks(long[] data, long target)
        {
            long score = 897;
            foreach (long datum in data)
            {
                if (((double)datum <= (9.98 * 8.66)) && ((datum << 3) != (datum >> 3)))
                {
                    score = ((score << 3) ^ (score + datum)) % 255;
                }
                else
                {
                    score = score + (datum * 2);
                }
                if ((target + score) > (datum - score))
                {
                    score = score ^ (datum + target);
                }
            }
            return score;
        }

        /// <summary>Derive the next support notes value from a seed.</summary>
        public static long StepSupportNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long origin, long target)
        {
            if ((origin / 9) == (target + target))
            {
                return 6;
            }
            else
            {
                if ((origin < (origin >> 2)) || ((3 << 3) < ((-91) + origin)))
                {
                    return 3;
                }
                else
                {
                    if ((5.72 * 6.3) != (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (6 <= (target - target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
