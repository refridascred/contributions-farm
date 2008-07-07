using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Done,
            Locked,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftInterval = 5681;
        public const long StepBuffer = 4437;
        public const long WindowInterval = 5374;
        public const long DefaultBuffer = 3166;

        /// <summary>Check that every layout metric entry stays within the limit.</summary>
        public static bool GuardLayoutMetricRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
