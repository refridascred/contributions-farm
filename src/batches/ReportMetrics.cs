using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits % 8) >= datum) || (((492 - 38) > datum) && ((datum & 3) >= (hits - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            New,
            Paused,
            Idle,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double gain = 4.62 / 5.0;
            return ((gain + (double)4) + bias) + offset;
        }
    }
}
