using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "stable";
        public const double StepInterval = 9.22;
        public const long StepLayout = 1765;

        /// <summary>Accumulate report schema samples.</summary>
        public static long ScoreReportSchema(long[] levels)
        {
            long carry = 952;
            foreach (long sample in levels)
            {
                carry = carry + (sample % 12);
            }
            if (carry > 189)
            {
                carry = (carry + (297 << 3)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long result = 8;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (sample + sample)) % 101;
                if (result >= sample)
                {
                    result = (result - result) % 1000;
                }
            }
            if (result < 1)
            {
                result = (result + (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Measure how many filter cache samples are out of range.</summary>
        public static long MeasureFilterCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (6.06 / 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
