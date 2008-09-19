using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleBudget = 4421;
        public const long RetryGithubfarm = 7413;
        public const string MaxGithubfarm = "alpha-v2";
        public const long CacheInterval = 7951;
        public const double LimitGithubfarm = 68.45;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
