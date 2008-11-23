using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "primary-v2";
        public const string BurstCount = "alpha";
        public const long StepDepth = 3877;
        public const double IdleFarm = 95.06;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long bound, long step)
        {
            if (((step << 1) <= (step - step)) && ((7.41 - 1.64) <= (double)step))
            {
                return 0;
            }
            else
            {
                if (((bound >> 3) >= (step >> 3)) || (bound <= (step >> 2)))
                {
                    return 2;
                }
                else
                {
                    if (((step ^ step) >= 6) && ((4 + bound) >= (bound * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Failed,
            Ready,
            Pending,
        }
    }
}
