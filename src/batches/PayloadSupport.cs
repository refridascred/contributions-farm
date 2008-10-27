using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double ratio = offset;
            return (ratio - ratio) + scale;
        }

        /// <summary>Iterate the command contributi series from a seed.</summary>
        public static long RollCommandContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long seed, long floor)
        {
            if ((16.0 <= (double)seed) || (seed > (seed + floor)))
            {
                return 4;
            }
            else
            {
                if ((1 - floor) <= floor)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
