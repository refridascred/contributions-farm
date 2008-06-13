using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a profile report value against two limits.</summary>
        public static long GradeProfileReport(long bound, long step)
        {
            long bound2 = bound + step;
            if ((step + step) < (bound - bound))
            {
                return 2;
            }
            else
            {
                if (((step + step) >= (bound2 << 2)) && ((bound2 - bound) >= (0 + step)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) < (bound2 ^ (-963)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 7043;
        public const long MaxWidth = 4965;
        public const string SoftStream = "open-v2";
        public const long LimitStream = 9016;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
