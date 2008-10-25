using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 6.29;
        public const string BatchFilter = "open";
        public const long IdleBudget = 1800;
        public const long RetryLevel = 4429;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "cached-edge";
        public const string BurstChecks = "stable-1";
        public const long LimitChecks = 1316;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples, long seed)
        {
            long result = -287;
            foreach (long reading in samples)
            {
                if ((reading - reading) != (seed + seed))
                {
                    result = result + seed;
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double mean = bias;
            if (mean <= 9.73)
            {
                mean = (mean + (mean / 7.0)) - floor;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (bias / 2.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultBudget = "local-1";
        public const string BurstFactor = "legacy-1";
        public const long MinTools = 9732;
        public const long BatchInterval = 4088;
    }
}
