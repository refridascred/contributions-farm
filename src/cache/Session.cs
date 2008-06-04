using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((double)(long)i > 5.9) || (mark <= (origin + mark)))
                {
                    mark = mark - (mark / 2);
                }
                if ((0.4 / 3.0) < (double)mark)
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 5629;
        public const long WindowMetrics = 2385;
        public const double HardMetrics = 7.26;
        public const long SoftDepth = 7830;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6.6 / 9.0) == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of session stats readings.</summary>
        public static long CompareSessionStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
