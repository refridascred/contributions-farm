using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 21.18;
        public const string StepFactor = "primary";
        public const long BaseBudget = 5357;

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 3011;
        public const long IdleBatch = 4791;
        public const double HardBatch = 40.53;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long target)
        {
            long step = bound - target;
            if (((step & 31) >= ((-71) % 60)) || ((step + 6) <= (target << 1)))
            {
                return 5;
            }
            else
            {
                if ((27 & 255) > bound)
                {
                    return 6;
                }
                else
                {
                    if ((-195) >= (step ^ target))
                    {
                        return 1;
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
