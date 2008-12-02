using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((double)limit == (double)item) || ((double)22 == (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)count < 5.78) || !((5 + entry) < (entry + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardLevel = 71.46;
        public const string HardRatio = "cached";
        public const long StepMetrics = 5682;
    }
}
