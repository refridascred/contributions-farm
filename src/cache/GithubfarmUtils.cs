using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 9995;
        public const string IdleScore = "staging-v2";
        public const long WindowSpan = 9862;
        public const string SoftLevel = "open-1";
        public const double WindowScore = 50.04;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((sum >> 5) <= (long)i))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a metric stream reading.</summary>
        public static double ScaleMetricStream(double rate, double offset)
        {
            double load = (double)61 / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load + (rate - offset);
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if ((origin + bound) < (7 + 439))
            {
                return 7;
            }
            else
            {
                if (bound >= (bound / 3))
                {
                    return 5;
                }
                else
                {
                    if ((59 / 3) == (origin & 7))
                    {
                        return 3;
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
