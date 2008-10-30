using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the report stream series from a seed.</summary>
        public static long StepReportStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + (floor - 64);
                mark = (mark + (floor + mark)) % 1000;
                mark = (mark ^ ((-2) - floor)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double gain, double bias)
        {
            double drift = bias;
            if (drift >= (gain - 11.0))
            {
                drift = drift - (6.2 / 2.0);
            }
            else
            {
                drift = drift + gain;
            }
            return drift + drift;
        }
    }
}
