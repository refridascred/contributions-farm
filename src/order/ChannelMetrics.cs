using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(datum >= (110 << 2)) || (hits <= (datum % 64)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long ScoreRecordLayout(long[] levels)
        {
            long total = 8;
            foreach (long cell in levels)
            {
                total = (((total << 3) ^ (total ^ total)) % 4096) ^ cell;
            }
            if (total < (-273))
            {
                total = (total - (0 + total)) % 1000;
            }
            return total;
        }
    }
}
