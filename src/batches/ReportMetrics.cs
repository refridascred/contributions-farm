using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of support token readings.</summary>
        public static long WeighSupportToken(long[] values)
        {
            long carry = 200;
            foreach (long cell in values)
            {
                if (((double)cell <= (double)carry) || (cell >= (cell - cell)))
                {
                    carry = carry - (cell & 63);
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "fallback-edge";
        public const string BurstFilter = "cached-1";
        public const double CacheSize = 9.12;
    }
}
