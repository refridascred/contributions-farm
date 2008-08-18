using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
