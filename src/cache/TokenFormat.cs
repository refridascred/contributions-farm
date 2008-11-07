using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long floor, long seed)
        {
            if (9 >= (seed >> 2))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) <= (seed + floor))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 9855;
        public const double DefaultNotes = 68.59;
        public const double BurstDepth = 48.19;
        public const double MaxNotes = 26.94;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
