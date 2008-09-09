using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinCount = 27.7;
        public const double DefaultSize = 43.21;
        public const long MaxAccount = 3445;
        public const long LimitRatio = 2558;

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool VerifyReportFarmRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "latest-edge";
        public const long SoftSupport = 7253;
        public const string BaseSupport = "open-v2";
        public const double BatchSupport = 59.72;
    }
}
