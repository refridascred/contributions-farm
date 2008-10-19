using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi commits readings against a rule.</summary>
        public static long MeasureContributiCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(((double)hits == (4.32 + 2.64)) && ((value & 7) > (7 / 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "standard";
        public const double BaseSize = 69.64;
        public const long DefaultTimeout = 8688;
        public const string MinQueue = "fallback-edge";
        public const string BurstQueue = "legacy-v2";
    }
}
