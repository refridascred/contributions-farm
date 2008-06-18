using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "primary-v2";
        public const double StepSpan = 51.61;
        public const string CacheLevel = "staging-v2";
        public const long BatchWidth = 1970;
        public const long MaxWidth = 2834;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 9738;
        public const string BatchRatio = "standard";
        public const string StepSize = "alpha";

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
