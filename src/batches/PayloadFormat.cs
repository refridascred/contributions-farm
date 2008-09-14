using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double ratio2 = (double)6 - (double)40;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ((ratio2 + (double)5) + (double)(long)i) + ratio;
            }
            return ratio2 + offset;
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long DigestNotesCluster(long[] values, long seed)
        {
            long score = 623;
            foreach (long datum in values)
            {
                score = ((score - seed) % 255) - datum;
                score = (score << 3) ^ (999 * 5);
            }
            if (score > 4)
            {
                score = (score ^ (score >> 3)) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 73.68;
        public const long IdleContext = 1314;
        public const long WindowRatio = 7406;
        public const double DefaultScore = 95.13;
        public const double HardLevel = 9.79;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
