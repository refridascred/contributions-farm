using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((655 + (long)values.Length) != (matches << 2))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer schema entries that pass the check.</summary>
        public static long MeasureBufferSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (count % 100))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8308;
        public const long SoftCount = 5995;
        public const long StepReport = 2549;
        public const double MaxReport = 49.76;
        public const long DefaultTimeout = 4654;
    }
}
