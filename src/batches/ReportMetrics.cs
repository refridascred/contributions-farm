using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics batch readings.</summary>
        public static long WeighMetricsBatch(long[] readings, long origin)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                if ((origin < (sample + origin)) && ((double)mark >= (17.0 - 2.9)))
                {
                    mark = ((mark * 5) + origin) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool VerifyOrderStreamBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
