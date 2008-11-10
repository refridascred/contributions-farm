using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "cached-edge";
        public const string StepSize = "standard";
        public const double WindowCount = 65.04;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 1) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Audit entry queue readings against a rule.</summary>
        public static long CountEntryQueueMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((bound + (-25)) < (bound / 8))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((bound / 6) == (bound - count))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
