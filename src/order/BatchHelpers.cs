using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor * 4) + (seed + anchor)) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long step)
        {
            long total = 36;
            foreach (long sample in items)
            {
                if ((total - total) > (75 * 4))
                {
                    total = ((total - 730) - sample) - step;
                }
                else
                {
                    total = (total + total) % 4096;
                }
            }
            if (total < (-63))
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
