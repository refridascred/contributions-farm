using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double drift = gain + (double)6;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (double)1;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool ValidateProfileWindowRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
