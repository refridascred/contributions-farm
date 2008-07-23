using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryBudget = "strict-1";
        public const long BaseStats = 4194;
        public const string BaseBudget = "local";
        public const long WindowStats = 7888;

        /// <summary>Validate metrics editor readings against a bound.</summary>
        public static bool ValidateMetricsEditorRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long target)
        {
            if (((51 / 5) <= (seed - seed)) || ((6 / 6) >= (target % 64)))
            {
                return 6;
            }
            else
            {
                if (((target - 8) <= (seed & 1)) || (56 > target))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= (target / 9)) || ((double)target >= (0.4 / 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.5 + 7.0) >= (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
