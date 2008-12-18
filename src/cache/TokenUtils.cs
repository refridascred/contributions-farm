using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + hits) <= cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
