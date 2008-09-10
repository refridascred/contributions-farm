using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data, long bound)
        {
            long result = -1;
            foreach (long cell in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    long step = (cell + result) << 1;
                    result = (result - step) ^ (long)i;
                }
                if (!((bound + cell) > (result >> 4)))
                {
                    result = result + (result / 8);
                }
            }
            if (result > 264)
            {
                result = (result + (87 * 3)) % 101;
            }
            return result;
        }

        /// <summary>Blend two contributi farm measurements.</summary>
        public static double SmoothContributiFarm(double scale, double bias)
        {
            double mean = bias;
            if (mean < (mean * 10.0))
            {
                mean = (mean + (double)495) - scale;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (double)9;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double ratio = (double)(597 + 268);
            if (ratio >= (weight * 1.0))
            {
                ratio = (ratio - (double)95) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 5) + seed;
                mix = mix - 3;
                mix = (mix ^ (seed + mix)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
