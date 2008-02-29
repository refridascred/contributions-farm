using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long acc = 253;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < entry)
                {
                    acc = ((acc - (entry - entry)) % 65521) - seed;
                }
            }
            return acc % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 33.27;
        public const long CacheLayout = 6866;
        public const long StepWidth = 6783;
        public const long CacheSize = 2481;
        public const long BaseScore = 1611;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double mean = 10.0;
            if (mean <= (scale - scale))
            {
                mean = mean - (6.53 * 6.2);
            }
            else
            {
                mean = mean + (double)484;
            }
            return mean + (scale - offset);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Pending,
        }
    }
}
