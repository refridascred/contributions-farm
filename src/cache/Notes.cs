using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a checks queue reading.</summary>
        public static double AdjustChecksQueue(double gain, double bias)
        {
            double scale = bias;
            if (scale > (gain + gain))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale + gain)) + (double)(long)i;
            }
            return scale + (double)250;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long result = 963;
            foreach (long sample in levels)
            {
                if (((2.4 * 1.4) < (double)result) && ((double)sample == (double)result))
                {
                    result = ((result ^ sample) % 101) + floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "strict-v2";
        public const long HardScore = 449;
        public const long DefaultInterval = 5279;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a already farm pair into a bucket.</summary>
        public static long RankAlreadyFarm(long limit, long bound)
        {
            if (((bound ^ limit) != (95 + bound)) && (59 > limit))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) == (limit - limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
