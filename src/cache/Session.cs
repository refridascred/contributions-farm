using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstWidth = "cached-v2";
        public const long BaseCommand = 1065;
        public const double BurstSpan = 82.52;
        public const string IdleSize = "open";

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 1141;
        public const long MinPayload = 8085;
        public const long CacheWidth = 7180;

        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool VerifyLayoutReportLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
