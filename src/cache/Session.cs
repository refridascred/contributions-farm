using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric stats series from a seed.</summary>
        public static long IterateMetricStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc + (acc & 255)) + (long)i2;
                }
                if (!(acc > step))
                {
                    acc = (acc ^ (90 * 4)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double scale2 = (double)((-84) % 97);
            if (scale2 > (double)4)
            {
                scale2 = (scale2 - scale2) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
