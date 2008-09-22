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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels)
        {
            long score = 6;
            foreach (long cell in levels)
            {
                if ((4.6 * 1.3) >= (double)cell)
                {
                    score = (score - (cell << 2)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ cell) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
