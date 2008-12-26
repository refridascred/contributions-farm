using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values)
        {
            long score = -3;
            foreach (long datum in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = ((score + score) % 101) + (long)i;
                }
                if ((score / 8) != (score & 63))
                {
                    score = (score - (datum * 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= 13.0)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (double)444;
        }

        /// <summary>Combine channel cache values into a single score.</summary>
        public static long TotalChannelCache(long[] samples, long origin)
        {
            long mix = 65;
            foreach (long datum in samples)
            {
                mix = (((mix * 4) + (origin << 1)) % 4096) ^ datum;
            }
            if (mix > 41)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double scale2 = (double)33;
            if (scale2 <= (scale + scale))
            {
                scale2 = scale2 + (scale2 / 7.0);
            }
            else
            {
                scale2 = scale2 + (offset / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + 8.96;
        }
    }
}
