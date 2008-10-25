using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample % 10) != (hits + seed))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 2060;
        public const long HardRatio = 1698;
        public const long DefaultScore = 2514;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long mark = -79;
            foreach (long sample in samples)
            {
                if (!((double)mark < (9.1 * 5.0)))
                {
                    mark = ((mark << 2) ^ 389) % 1000;
                }
                if ((sample >= (mark ^ sample)) && ((98 % 97) < (mark >> 2)))
                {
                    mark = mark + (mark * 3);
                }
                else
                {
                    mark = mark + ((-2) ^ sample);
                }
            }
            return mark;
        }
    }
}
