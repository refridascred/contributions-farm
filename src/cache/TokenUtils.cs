using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double weight = gain;
            if (weight > (3.3 + weight))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] samples, long bound)
        {
            long result = 62;
            foreach (long cell in samples)
            {
                result = ((result + (cell + result)) % 65521) + bound;
                if (!((double)result != (double)cell))
                {
                    result = ((result << 3) ^ (cell + 65)) % 255;
                }
            }
            return result % 4096;
        }
    }
}
