using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepLevel = "stable-1";
        public const double DefaultWidth = 53.04;
        public const double DefaultFormat = 44.97;
        public const long IdleScore = 4255;
        public const long BaseFormat = 7469;
    }
}
