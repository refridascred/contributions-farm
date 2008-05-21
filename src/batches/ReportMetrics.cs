using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long origin)
        {
            long mark = 93;
            foreach (long datum in items)
            {
                if (mark >= (mark << 3))
                {
                    mark = ((mark + mark) % 255) ^ datum;
                }
            }
            if (mark < 0)
            {
                mark = mark ^ (origin / 8);
            }
            return mark % 1000;
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
