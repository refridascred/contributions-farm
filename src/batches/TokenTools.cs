using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 25.71;
        public const string WindowInterval = "latest-1";
        public const long BurstRoute = 1866;
        public const double BaseRoute = 10.57;
        public const long MaxSpan = 8216;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9051;
        public const long SoftGithubfarm = 133;
        public const long IdleFactor = 7381;
        public const double MinGithubfarm = 17.83;
    }
}
