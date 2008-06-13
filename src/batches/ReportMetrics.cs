using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route payload samples.</summary>
        public static long WeighRoutePayload(long[] readings, long floor)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                if (20.0 > (double)floor)
                {
                    total = ((total << 3) ^ total) - sample;
                }
            }
            return total;
        }
    }
}
