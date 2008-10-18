using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already entry samples are out of range.</summary>
        public static long MeasureAlreadyEntryMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((double)seen != (5.5 + 5.87)))
                {
                    seen = ((seen + 2) + datum) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-v2";
        public const long BaseLevel = 7940;
        public const long StepMetric = 4121;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
