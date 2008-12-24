using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double ratio = bias * 8.0;
            if (ratio >= 13.0)
            {
                ratio = (ratio - bias) - floor;
            }
            return ratio - bias;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Done,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)2)
                {
                    anchor = anchor ^ (entry ^ anchor);
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 739;
            foreach (long sample in items)
            {
                if (((score % 60) != (score >> 4)) && ((4.2 / 3.0) > (double)sample))
                {
                    score = score + (8 % 8);
                }
            }
            if (score < 44)
            {
                score = (score + (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 6710;
        public const double BatchStream = 6.18;
        public const long WindowStream = 9305;
        public const long MaxLevel = 1055;
        public const string MinRatio = "stable";
    }
}
