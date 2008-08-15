using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 4568;
        public const string StepFactor = "latest-edge";
        public const long StepChannel = 7946;
        public const long RetryDepth = 3003;

        /// <summary>Rank schema checks input into a small class.</summary>
        public static long BucketSchemaChecks(long bound, long floor)
        {
            long edge = bound ^ floor;
            if (bound > floor)
            {
                return 4;
            }
            else
            {
                if ((double)bound > (2.4 - 0.51))
                {
                    return 1;
                }
                else
                {
                    if (!((bound / 8) > edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor <= (double)bound) && ((bound + (-9)) < (5 + (-47))))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
