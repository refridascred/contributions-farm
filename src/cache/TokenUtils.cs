using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double scale = offset / 9.0;
            return (scale + (offset / 8.0)) + bias;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long state = 201;
            foreach (long entry in levels)
            {
                long diff = entry;
                state = (state * 3) + (diff << 3);
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long limit)
        {
            if ((limit % 8) == (2 + step))
            {
                return 1;
            }
            else
            {
                if (!((19.0 - 3.99) < (double)step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
