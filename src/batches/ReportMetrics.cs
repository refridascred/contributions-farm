using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
