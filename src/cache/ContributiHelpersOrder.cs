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

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long target)
        {
            long mix = 163;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (reading << 3)) % 255) + target;
            }
            return mix;
        }
    }
}
