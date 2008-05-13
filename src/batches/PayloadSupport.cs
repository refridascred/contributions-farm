using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 7770;
        public const long HardLevel = 1502;
        public const string MinScore = "primary-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4665;
        public const long BatchNotes = 759;
        public const double IdleInterval = 33.16;
        public const double WindowFactor = 43.38;
        public const double MinInterval = 58.57;

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long seed)
        {
            if (seed <= (seed << 2))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) >= seed) && ((floor + floor) < floor))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
