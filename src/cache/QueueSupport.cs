using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values)
        {
            long score = 300;
            foreach (long entry in values)
            {
                score = ((score * 4) + score) % 255;
                if ((score + score) <= (score >> 1))
                {
                    long offset = 423 + score;
                    score = score - (offset + (long)values.Length);
                }
                if (entry < (entry + entry))
                {
                    score = ((score << 3) ^ (entry >> 5)) % 255;
                }
                else
                {
                    score = score + entry;
                }
            }
            return score % 65521;
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
