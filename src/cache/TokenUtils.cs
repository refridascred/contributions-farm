using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 11.5;
        public const long HardRatio = 5955;
        public const long BaseBudget = 2215;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
