using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 35.99;
        public const long SoftCount = 9673;
        public const string MaxEditor = "stable-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 1533;
        public const string BaseProfile = "fallback";
        public const long RetryProfile = 4444;
        public const long StepTimeout = 4098;

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
