using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2287;
        public const string StepScore = "fallback";
        public const string BurstTimeout = "fallback-v2";
        public const long SoftFactor = 1688;
        public const long CacheEntry = 3464;

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long CountQueueTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (11.0 + 6.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((3.81 * 18.0) < (double)origin)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry batches measurements.</summary>
        public static double BlendEntryBatches(double scale, double floor)
        {
            double bias = floor * 6.9;
            if (bias > bias)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (floor / 3.0)) - (double)(long)i;
            }
            return bias - (12.0 - floor);
        }
    }
}
