using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (866 <= (seen - seen))
                {
                    seen = ((seen + 2) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
