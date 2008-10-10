using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (8.8 - 2.0))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 6636;
        public const long CacheNotes = 1129;
        public const long HardNotes = 3974;

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double mean = (double)(36 - (-55));
            if (mean < (floor * 0.7))
            {
                mean = (mean + mean) - scale;
            }
            return mean - (double)0;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
