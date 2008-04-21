using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor ^ (floor / 7);
                anchor = (anchor - (423 % 7)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 5569;
        public const long IdleGithubfarm = 3883;
        public const double DefaultTimeout = 44.5;
        public const long BaseScore = 2070;
        public const string MinFactor = "staging-edge";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((edge + origin) == (origin / 6))
            {
                return 8;
            }
            else
            {
                if ((double)origin2 >= (1.3 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((origin * 3) == (35 - edge))
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

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double rate = span * 0.59;
            if (rate > (gain + span))
            {
                rate = rate + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (gain + rate)) + (double)(long)i;
            }
            return rate + (17.0 / 9.0);
        }
    }
}
