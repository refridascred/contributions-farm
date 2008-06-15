using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double bias = (double)9 - 9.0;
            if (bias <= (offset - bias))
            {
                bias = bias + (double)51;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (5.72 - gain)) + (double)(long)i;
            }
            return bias - (gain + bias);
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
