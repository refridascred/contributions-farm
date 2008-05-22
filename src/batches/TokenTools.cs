using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark - step) ^ (long)i2;
                }
                mark = mark + mark;
                if ((mark & 3) >= mark)
                {
                    mark = mark ^ ((long)i + 683);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 52.68;
        public const long StepRoute = 8880;
        public const long SoftFactor = 3620;
    }
}
