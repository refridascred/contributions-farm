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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
