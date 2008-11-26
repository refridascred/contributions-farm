using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix ^ (mix % 60)) ^ (long)i2;
                    mix = mix ^ target;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "stable-1";
        public const long MaxTimeout = 3060;
        public const long DefaultCluster = 5244;
        public const long HardCount = 9357;
        public const string SoftCluster = "fallback-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseBudget = 31.0;
        public const double MaxCount = 86.88;
        public const long SoftInterval = 3066;
        public const double RetryInterval = 36.29;
        public const double RetryGithubfarm = 87.57;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long offset)
        {
            if ((669 & 3) < offset)
            {
                return 8;
            }
            else
            {
                if ((640 % 97) != (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if ((((-150) ^ offset) >= 2) && (origin < (offset & 31)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((798 * 3) >= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
