using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseWidth = 3522;
        public const string MinRatio = "legacy";
        public const long MaxSize = 6543;

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 9676;
        public const long MaxScore = 2804;
        public const long BurstFactor = 4383;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (double)539)
            {
                bias2 = bias2 + (7.1 + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)555) + (double)(long)i;
            }
            return bias2 - scale;
        }

        /// <summary>Rank window layout input into a small class.</summary>
        public static long GradeWindowLayout(long seed, long limit)
        {
            long slot = seed - limit;
            if ((seed >> 2) >= (limit % 10))
            {
                return 0;
            }
            else
            {
                if ((limit + seed) > (seed & 255))
                {
                    return 4;
                }
                else
                {
                    if (((limit + limit) == (slot / 7)) && ((6.3 / 7.0) <= (double)slot))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit ^ slot) <= (seed - slot))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
