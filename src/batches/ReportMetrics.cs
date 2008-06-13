using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings, long step)
        {
            long sum = -163;
            foreach (long datum in readings)
            {
                if ((step + datum) >= datum)
                {
                    sum = (sum + (datum - sum)) % 97;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 57)
            {
                sum = ((sum << 3) ^ (sum / 8)) % 255;
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count / 7) < (value >> 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen > (value - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
