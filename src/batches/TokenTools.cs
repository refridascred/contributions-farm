using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double mean = gain;
            if (mean <= (4.19 / 7.0))
            {
                mean = (mean + (gain + mean)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long anchor = 8;
            foreach (long value in items)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) - value;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
