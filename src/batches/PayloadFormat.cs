using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a context queue value against two limits.</summary>
        public static long BucketContextQueue(long seed, long step)
        {
            if (!((seed + step) <= (seed / 9)))
            {
                return 5;
            }
            else
            {
                if (((step << 1) >= (923 / 5)) && (53 >= (step / 4)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5700;
        public const long SoftGithubfarm = 7928;
        public const string BatchGithubfarm = "standard-1";
        public const long HardGithubfarm = 5796;
        public const double StepBudget = 40.06;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
