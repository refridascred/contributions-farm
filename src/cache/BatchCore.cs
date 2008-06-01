using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 6588;
        public const long DefaultFilter = 7494;
        public const long MinFilter = 9729;

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double gain = bias;
            if (gain >= (double)46)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + bias;
            }
            return gain - (weight + gain);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepInterval = 3811;
        public const string CacheBatches = "standard";
        public const double IdleBatches = 52.4;

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 9158;
        public const string LimitDepth = "latest-v2";
        public const string HardAlready = "latest-1";
    }
}
