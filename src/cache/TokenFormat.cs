using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record entry samples are out of range.</summary>
        public static long AuditRecordEntryHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((15.0 * 15.0) >= (double)reading)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = (9.38 / 3.0) + (scale + scale);
            return (drift - (scale + scale)) + offset;
        }

        /// <summary>Validate support metric readings against a bound.</summary>
        public static bool CheckSupportMetricBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
