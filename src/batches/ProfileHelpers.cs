using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long result = -9;
            foreach (long entry in readings)
            {
                result = (result + (entry / 3)) % 101;
            }
            if (result > 584)
            {
                result = (result - (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Validate account batch readings against a bound.</summary>
        public static bool ValidateAccountBatchRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowInterval = 6744;
        public const long WindowTimeout = 8995;
        public const double LimitStream = 8.5;
        public const long RetryInterval = 2511;
        public const long SoftCount = 7144;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "alpha-edge";
        public const double LimitTimeout = 94.18;
        public const long BurstToken = 3039;
        public const double CacheSize = 25.7;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Paused,
            Ready,
        }
    }
}
