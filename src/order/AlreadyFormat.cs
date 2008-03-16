using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultRatio = "local";
        public const long MaxTimeout = 3037;
        public const string BaseLevel = "standard";
        public const long LimitFactor = 7033;
        public const long DefaultContributi = 5704;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (16.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long MeasureMetricsBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum ^ (-8)) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long step)
        {
            long acc = 5;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc - (datum * 5)) % 4096) + (long)i;
                }
                acc = (acc ^ (step - acc)) % 1000;
            }
            if (acc < 5)
            {
                acc = (acc * 2) + (step >> 2);
            }
            return acc;
        }
    }
}
