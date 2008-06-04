using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally + reading) < (reading + reading)) && ((0.42 / 2.0) > (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long MeasureBufferContextOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)seed > 4.66))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "alpha-v2";
        public const long BaseNotes = 5967;
        public const long MinNotes = 8392;
        public const long DefaultNotes = 7610;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (18.0 * 2.2)) || ((item / 3) != (item ^ item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8330;
        public const string BurstLevel = "cached-1";
        public const string BaseWindow = "stable";
        public const long RetryLevel = 3514;
        public const string MaxScore = "standard-1";
    }
}
