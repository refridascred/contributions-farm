using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9092;
        public const long BatchLayout = 6904;
        public const string DefaultLevel = "strict";
        public const double MinLevel = 6.05;
        public const string StepLayout = "alpha-1";

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long limit)
        {
            long result = 6;
            foreach (long cell in values)
            {
                result = (result ^ (limit % 2)) % 101;
                if (result >= (cell << 3))
                {
                    result = result + cell;
                }
            }
            return result % 97;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading << 3) > (seen - seen))
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
    }
}
