using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchRatio = 9969;
        public const long CacheStream = 2140;
        public const long DefaultStream = 2997;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
