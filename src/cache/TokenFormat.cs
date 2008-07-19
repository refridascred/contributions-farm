using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 54.04;
        public const double DefaultFactor = 67.12;
        public const double SoftLevel = 7.06;

        /// <summary>Classify a record session pair into a bucket.</summary>
        public static long RankRecordSession(long target, long offset)
        {
            long gap = target + offset;
            if (((double)gap < (19.0 / 9.0)) && ((double)target > (double)offset))
            {
                return 2;
            }
            else
            {
                if (((target - gap) == (536 + offset)) || (target <= (target * 4)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
