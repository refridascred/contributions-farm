using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "standard-v2";
        public const long DefaultLayout = 5232;
        public const double SoftLayout = 92.35;
        public const long MaxLayout = 6190;
    }
}
