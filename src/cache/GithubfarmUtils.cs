using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double BlendOrderLayout(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (rate / 8.0))
            {
                bias = bias - (rate / 8.0);
            }
            return bias - (bias + offset);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 6079;
        public const double WindowLevel = 5.89;
        public const double StepSupport = 15.11;
        public const long MaxSupport = 8640;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Retry,
            Draft,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long bound)
        {
            if ((double)bound <= (double)490)
            {
                return 1;
            }
            else
            {
                if ((double)bound < (5.5 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if (bound <= (4 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + bound) > (bound % 97))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
