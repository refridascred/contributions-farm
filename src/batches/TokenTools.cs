using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (offset - drift))
            {
                drift = (drift + drift) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + 16.0;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                if ((carry * 2) < (carry << 2))
                {
                    carry = carry + (sample >> 3);
                }
                else
                {
                    carry = (carry + (carry + (-99))) % 1000;
                }
            }
            return carry;
        }
    }
}
