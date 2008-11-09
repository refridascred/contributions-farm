using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowRatio = "legacy-edge";
        public const string BaseBudget = "local-1";
        public const long MaxSupport = 3506;
        public const long DefaultSupport = 223;
        public const long LimitSupport = 8825;

        /// <summary>Grade a filter session value against two limits.</summary>
        public static long GradeFilterSession(long bound, long target)
        {
            if (!((0.3 - 8.3) != (double)bound))
            {
                return 3;
            }
            else
            {
                if ((7.5 + 9.15) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstInterval = "primary-v2";
        public const long BurstStream = 8045;
        public const long RetryStream = 768;
    }
}
