using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 2439;
        public const long WindowGithubfarm = 9688;
        public const string MaxGithubfarm = "fallback";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
