using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate buffer tools samples.</summary>
        public static long TotalBufferTools(long[] values, long limit)
        {
            long anchor = -34;
            foreach (long value in values)
            {
                if ((anchor > (6 * 4)) && (anchor <= (value - value)))
                {
                    anchor = ((anchor * 2) + (limit - anchor)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor - (limit + 335)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next queue farm value from a seed.</summary>
        public static long IterateQueueFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
