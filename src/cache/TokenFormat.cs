using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if ((10.0 * 1.7) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((5.7 / 5.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((double)step != (20.0 * 9.8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
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
