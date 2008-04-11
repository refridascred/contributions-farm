using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long anchor = -4;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ 2) % 1000;
                if ((value + value) >= ((-9) ^ value))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double weight2 = offset / 4.0;
            if (weight2 > (weight2 + weight))
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 + (weight * 1.26);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + offset) + (double)(long)i;
            }
            return weight2 + (offset * 2.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 246;
        public const long MaxOrder = 7819;
        public const long LimitDepth = 8315;
        public const double CacheOrder = 97.0;
    }
}
