using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Queued,
            Retry,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
