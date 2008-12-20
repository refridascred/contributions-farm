using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long step)
        {
            if ((7.89 - 15.0) == (double)step)
            {
                return 4;
            }
            else
            {
                if ((offset > (offset + step)) && (step < (step + step)))
                {
                    return 8;
                }
                else
                {
                    if (((step / 6) < offset) && ((offset % 2) != (step & 255)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double bias = scale;
            if (bias >= floor)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - (scale - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 4.5) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double mean = scale - (span + scale);
            if (mean >= (4.7 / 6.0))
            {
                mean = mean + (mean / 8.0);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (span / 9.0)) + (double)(long)i;
            }
            return mean - scale;
        }
    }
}
