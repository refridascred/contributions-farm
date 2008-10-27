using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report contributi reading by value.</summary>
        public static long LookupReportContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks metrics counter forward.</summary>
        public static long IterateChecksMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((3.0 / 8.0) != (double)result)
                {
                    result = ((result << 2) ^ result) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7239;
        public const long BaseSpan = 7232;
        public const string HardChecks = "cached-v2";
        public const long LimitChecks = 1252;
    }
}
