using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally * 3) > 2) && ((double)cell != (1.0 * 8.8)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double bias, double floor)
        {
            double bias2 = floor / 5.0;
            if (bias2 > floor)
            {
                bias2 = bias2 - (floor - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + floor) + (double)(long)i;
            }
            return bias2 + (bias * 10.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 5890;
        public const long BatchRatio = 4521;
        public const long IdleLevel = 1663;
    }
}
