using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double bias)
        {
            double scale = (double)(706 & 127);
            if (scale > (gain / 8.0))
            {
                scale = scale - 8.0;
            }
            else
            {
                scale = scale + (bias * 19.0);
            }
            return scale + scale;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long anchor = -8;
            foreach (long cell in series)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = (anchor - (4 & 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 5866;
        public const long StepWidth = 3527;
        public const long WindowWidth = 8993;
        public const long BaseStats = 8022;
        public const long IdleStats = 1836;
    }
}
