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

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if ((4.0 + 3.91) <= (double)total)
                {
                    total = total + (0 & 63);
                }
                if ((sample + sample) == (total + total))
                {
                    total = ((total << 3) ^ (total + total)) % 4096;
                }
                else
                {
                    total = total ^ (total ^ total);
                }
            }
            return total;
        }

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
