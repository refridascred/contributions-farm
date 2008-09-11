using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-v2";
        public const double BurstGithubfarm = 90.49;
        public const double StepTimeout = 20.02;

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double load = span;
            if (load <= (double)0)
            {
                load = load - (span + scale);
            }
            return load + (7.4 - load);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
