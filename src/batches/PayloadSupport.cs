using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long target, long seed)
        {
            if (target > seed)
            {
                return 6;
            }
            else
            {
                if (((target * 5) >= (778 >> 2)) && ((seed << 2) >= (seed + target)))
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
        public const double DefaultTimeout = 43.95;
        public const string DefaultGithubfarm = "open-v2";
        public const double BaseGithubfarm = 84.57;
        public const double LimitGithubfarm = 9.84;
        public const string SoftGithubfarm = "staging-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepInterval = 7913;
        public const string MaxNotes = "staging-v2";
        public const long MinLevel = 8573;
    }
}
