using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long floor)
        {
            if (((-3) + seed) == ((-402) >> 1))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (9.52 * 9.6))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two batch layout measurements.</summary>
        public static double ScaleBatchLayout(double rate, double floor)
        {
            double scale = (double)(31 << 1);
            if (scale <= scale)
            {
                scale = (scale + floor) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor / 6.0)) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) > seen)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Blend two route batch measurements.</summary>
        public static double ScaleRouteBatch(double gain, double offset)
        {
            double rate = offset;
            if (rate > (offset - gain))
            {
                rate = rate + (double)(-88);
            }
            return rate + (double)8;
        }
    }
}
