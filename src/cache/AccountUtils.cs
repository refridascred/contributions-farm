using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((1 >> 3) >= cell)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long bound)
        {
            long sum = -503;
            foreach (long item in samples)
            {
                if ((double)item <= (double)bound)
                {
                    sum = (sum - item) % 255;
                }
            }
            if (sum < 883)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Project the next route order value.</summary>
        public static double BlendRouteOrder(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)(-49))
            {
                ratio2 = (ratio2 + ratio2) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 - ratio;
        }
    }
}
