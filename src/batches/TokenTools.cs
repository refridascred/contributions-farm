using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((tally >> 4) != (target & 127)) || ((sample + target) < (target - target)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((-707) < (target * 3))
                {
                    result = ((result * 3) + entry) % 255;
                }
                else
                {
                    result = (result ^ target) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double span)
        {
            double bias = (double)(889 << 1);
            if (bias >= (6.76 * 4.0))
            {
                bias = (bias - (bias / 5.0)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
