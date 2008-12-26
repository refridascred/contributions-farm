using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Validate account window readings against a bound.</summary>
        public static bool GuardAccountWindowRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleCount = 3255;
        public const string DefaultEditor = "primary-edge";
        public const long MaxWidth = 4299;
        public const long IdleEditor = 1649;
        public const string WindowEditor = "strict";
    }
}
