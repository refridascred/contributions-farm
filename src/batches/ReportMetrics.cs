using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "alpha";
        public const string IdleDepth = "stable-v2";
        public const string BurstContributi = "stable-v2";
        public const long MinDepth = 9697;

        /// <summary>Rank support order input into a small class.</summary>
        public static long ClassifySupportOrder(long floor, long step)
        {
            long step2 = floor + step;
            if ((step % 7) < (44 + floor))
            {
                return 0;
            }
            else
            {
                if (((step + step2) > (step2 - step2)) && ((step2 + step2) < (floor & 7)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
