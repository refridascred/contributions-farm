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

        /// <summary>Count batch support pairs that satisfy a relation.</summary>
        public static long OverlapBatchSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload channel readings against a rule.</summary>
        public static long AuditPayloadChannelHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - cell) < (cell ^ bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
