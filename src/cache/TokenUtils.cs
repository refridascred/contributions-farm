using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 143;
        public const long WindowContext = 7224;
        public const double HardLevel = 82.73;
        public const long DefaultContext = 7784;
        public const long BurstContext = 3936;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i < anchor) || ((anchor + (long)i) >= (offset % 2)))
                {
                    anchor = (anchor + (long)i) % 65521;
                }
                if (!((offset + 0) < anchor))
                {
                    anchor = (anchor ^ offset) % 65521;
                }
                if ((6.1 - 1.0) != (double)anchor)
                {
                    anchor = (anchor << 2) ^ (anchor - offset);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long step)
        {
            if ((step + 375) < step)
            {
                return 0;
            }
            else
            {
                if (!((3 << 1) < floor))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 / 2.0) == (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
