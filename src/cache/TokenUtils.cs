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

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double gain = scale * 0.67;
            if (gain <= 18.0)
            {
                gain = gain + (floor - 5.0);
            }
            else
            {
                gain = gain + 13.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (floor / 9.0)) - (double)(long)i;
            }
            return gain + (double)918;
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
