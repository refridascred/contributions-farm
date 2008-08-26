using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long total = 87;
            foreach (long value in values)
            {
                total = (total + (value << 3)) % 101;
                if (value < (total >> 4))
                {
                    total = (total + (total - value)) % 255;
                }
            }
            if (total < 8)
            {
                total = (total * 5) + (112 >> 3);
            }
            return total % 1000;
        }

        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long AuditPayloadBatchMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell > (count * 3)) && ((cell - count) >= step))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
