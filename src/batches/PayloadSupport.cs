using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
