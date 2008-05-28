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

        /// <summary>Iterate the report githubfarm series from a seed.</summary>
        public static long RollReportGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + seed) % 97;
                if ((seed + carry) < (seed + seed))
                {
                    carry = ((carry << 3) ^ (long)i) % 101;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 5866;
        public const long StepWidth = 3527;
        public const long WindowWidth = 8993;
        public const long BaseStats = 8022;
        public const long IdleStats = 1836;
    }
}
