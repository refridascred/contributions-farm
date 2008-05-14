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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long step)
        {
            if ((1 % 5) <= (866 + step))
            {
                return 2;
            }
            else
            {
                if ((offset / 4) > (offset % 10))
                {
                    return 3;
                }
                else
                {
                    if (step < (step / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset - offset) < (step / 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

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

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 574;
            foreach (long sample in levels)
            {
                carry = (carry ^ sample) % 1000;
            }
            return carry % 4096;
        }
    }
}
