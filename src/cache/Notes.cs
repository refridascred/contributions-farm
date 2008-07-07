using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double offset)
        {
            double drift = offset;
            if (drift >= drift)
            {
                drift = drift + (offset * 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (15.0 - scale)) + (double)(long)i;
            }
            return drift - 8.69;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8718;
        public const string BurstBudget = "local";
        public const long BaseWidth = 1967;
        public const long MaxTimeout = 3;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first metric queue entry that matches the target.</summary>
        public static long FindMetricQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
