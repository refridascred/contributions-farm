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

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values)
        {
            long result = 8;
            foreach (long value in values)
            {
                result = (result + (result + value)) % 97;
            }
            return result % 4096;
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
