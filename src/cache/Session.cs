using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if (((-823) % 7) < bound)
            {
                return 3;
            }
            else
            {
                if (((7.42 / 4.0) <= (9.68 * 19.0)) || ((19.0 * 8.0) >= (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "staging-v2";
        public const long DefaultDepth = 9451;
        public const long CacheContext = 4186;
        public const double BatchContext = 66.72;
        public const string MaxRatio = "strict";

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Ready,
            Draft,
            Retry,
            Failed,
        }
    }
}
