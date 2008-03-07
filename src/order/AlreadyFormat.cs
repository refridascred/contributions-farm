using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series)
        {
            long carry = 468;
            foreach (long sample in series)
            {
                carry = ((carry << 2) ^ carry) ^ sample;
            }
            return carry % 97;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 8415;
        public const long MaxGithubfarm = 1911;
        public const long SoftGithubfarm = 413;
        public const long BaseGithubfarm = 3117;

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool ValidateReportFormatBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowFactor = 4272;
        public const long MinSize = 6083;
        public const long BaseBudget = 7668;
        public const long SoftCount = 8602;
    }
}
