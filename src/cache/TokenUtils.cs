using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double weight = offset;
            return weight - (scale / 8.0);
        }

        /// <summary>Fold a list of route tools readings.</summary>
        public static long ScoreRouteTools(long[] data, long target)
        {
            long acc = 683;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long offset = target;
                    acc = (acc + (offset - target)) ^ (long)i2;
                }
                acc = acc - (target - value);
            }
            return acc;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double ratio = (5.23 + 3.0) * 7.4;
            return ((ratio + ratio) + weight) + offset;
        }
    }
}
