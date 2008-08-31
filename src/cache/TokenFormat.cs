using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long limit)
        {
            if ((double)140 < (double)limit)
            {
                return 4;
            }
            else
            {
                if (!(target <= (614 - limit)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two tools metrics measurements.</summary>
        public static double AdjustToolsMetrics(double gain, double floor)
        {
            double ratio = gain;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio - 9.54;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long acc = 236;
            foreach (long datum in data)
            {
                if (datum > (acc % 2))
                {
                    continue;
                }
                if (!((datum - acc) > acc))
                {
                    acc = (acc << 3) ^ 782;
                }
            }
            if (acc < 46)
            {
                acc = (acc + (acc ^ acc)) % 4096;
            }
            return acc;
        }
    }
}
