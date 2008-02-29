using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits % 97) != (hits - hits))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 6115;
        public const string BatchFormat = "legacy-1";
        public const long RetryFormat = 8152;
        public const long BurstSpan = 1654;
    }
}
