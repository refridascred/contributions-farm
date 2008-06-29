using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleLevel = 6917;
        public const long WindowScore = 9546;
        public const long CacheWidth = 546;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long limit, long floor)
        {
            if ((double)limit == (1.74 / 2.0))
            {
                return 4;
            }
            else
            {
                if ((7.7 * 7.1) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
