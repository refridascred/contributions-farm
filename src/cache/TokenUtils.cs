using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long bound)
        {
            long total = 894;
            foreach (long cell in levels)
            {
                if (((450 + 57) == (cell + total)) && (total <= cell))
                {
                    total = ((total * 4) + (total + bound)) % 101;
                }
                if ((total % 16) <= total)
                {
                    total = (total - (4 << 1)) % 97;
                }
                else
                {
                    total = (total ^ (cell >> 4)) % 1000;
                }
            }
            if (total < 94)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= (double)67)
            {
                drift = (drift - (double)699) + ratio;
            }
            return drift - 3.2;
        }
    }
}
