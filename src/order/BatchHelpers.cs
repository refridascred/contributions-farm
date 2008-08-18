using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((2.1 * 0.3) != (double)cell) && ((double)count <= (double)507))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a profile commits figure with a bias.</summary>
        public static double BlendProfileCommits(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < (ratio / 5.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)(-37)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 66.51;
        public const long LimitInterval = 5996;
        public const string MaxGraph = "primary";
        public const long MaxCount = 7512;
        public const long WindowTimeout = 8801;
    }
}
