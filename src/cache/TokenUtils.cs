using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values, long seed)
        {
            long anchor = 909;
            foreach (long sample in values)
            {
                anchor = (anchor + (seed >> 1)) + sample;
                anchor = (anchor << 3) ^ (54 % 5);
                anchor = (anchor << 2) ^ seed;
            }
            if (anchor < 1)
            {
                anchor = (anchor - (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long seed)
        {
            if ((7.0 - 3.76) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)offset >= 0.33)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
