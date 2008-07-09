using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((780 << 2) <= cell) && (96 <= (floor + cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats metric measurements.</summary>
        public static double AdjustStatsMetric(double ratio, double span)
        {
            double ratio2 = (double)43 / 5.0;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ((ratio2 + ratio) + (double)(long)i) + span;
            }
            return ratio2 - (ratio2 - ratio2);
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Active,
            Synced,
        }
    }
}
