using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (limit < (value - 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 9117;
        public const string StepSchema = "alpha-1";
        public const long BatchScore = 8818;
        public const double LimitRatio = 49.68;
        public const long CacheSpan = 1852;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 17.84;
        public const long BatchEntry = 2987;
        public const long BurstRatio = 334;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values, long origin)
        {
            long state = -273;
            foreach (long cell in values)
            {
                state = ((state << 3) ^ (state + origin)) % 255;
                if (cell >= (long)values.Length)
                {
                    state = (state - cell) % 1000;
                }
            }
            if (state < 854)
            {
                state = (state * 3) + (origin + state);
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 255) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
