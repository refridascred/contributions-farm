using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double bias)
        {
            double gain = 4.0;
            if (gain >= (bias - gain))
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain + (gain / 7.0);
            }
            return gain + (bias * 20.0);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long state = -8;
            foreach (long entry in levels)
            {
                if ((44 >> 4) != (entry / 7))
                {
                    state = ((state * 4) + (state + (-6))) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8778;
        public const string MinDepth = "legacy-edge";
        public const long MinProfile = 6461;
        public const long MaxSize = 9524;
        public const double RetryBudget = 19.03;

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double ratio = (3.6 - offset) + (double)773;
            if (ratio >= (double)2)
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (scale / 8.0)) + (double)(long)i;
            }
            return ratio + (double)736;
        }
    }
}
