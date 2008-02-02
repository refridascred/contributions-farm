using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of layout cache readings.</summary>
        public static long TotalLayoutCache(long[] levels, long seed)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                if (!(((mix + (long)levels.Length) > (mix % 64)) && ((seed ^ mix) > mix)))
                {
                    mix = (mix + (mix % 64)) - sample;
                }
                mix = mix - (242 / 7);
                mix = mix ^ 2;
            }
            return mix;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double load = 20.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 8.65) - (double)(long)i) + offset;
            }
            return load + ratio;
        }
    }
}
