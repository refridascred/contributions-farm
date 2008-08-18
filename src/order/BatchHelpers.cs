using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7566;
        public const long BurstSpan = 8658;
        public const long BatchAlready = 7044;
        public const string BaseAlready = "fallback-edge";

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
