using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                if ((offset ^ value) < offset)
                {
                    sum = (sum + value) % 255;
                }
                else
                {
                    sum = (sum + offset) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 5023;
        public const string BurstEntry = "staging";
        public const double CacheEntry = 23.44;
        public const long WindowTimeout = 7901;
        public const long DefaultEntry = 1136;

        /// <summary>Combine schema account values into a single score.</summary>
        public static long ScoreSchemaAccount(long[] levels)
        {
            long anchor = -84;
            foreach (long value in levels)
            {
                if (anchor >= (anchor + value))
                {
                    anchor = (anchor * 4) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor - (value << 1)) % 97;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 65521;
        }
    }
}
