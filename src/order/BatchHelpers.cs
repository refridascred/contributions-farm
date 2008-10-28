using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry ^ 185) <= (entry & 3)) && ((entry % 10) != (entry + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
