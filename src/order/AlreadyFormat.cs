using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up payload batch samples.</summary>
        public static long ComparePayloadBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((10.0 + 3.3) >= (double)sample) || ((hits ^ hits) <= (sample - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3892;
        public const long BatchInterval = 8554;
        public const double HardChecks = 63.82;
        public const long BaseBudget = 3957;
    }
}
