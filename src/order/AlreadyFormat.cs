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

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double weight, double bias)
        {
            double scale = (double)(1 + 948);
            if (scale >= scale)
            {
                scale = (scale - bias) - weight;
            }
            else
            {
                scale = scale - 0.86;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (2.9 / 2.0)) - (double)(long)i;
            }
            return scale + (double)(-77);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 6710;
        public const double BatchStream = 6.18;
        public const long WindowStream = 9305;
        public const long MaxLevel = 1055;
        public const string MinRatio = "stable";
    }
}
