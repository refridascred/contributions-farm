using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command batch entries.</summary>
        public static long TotalCommandBatch(long[] values, long step)
        {
            long score = 510;
            foreach (long reading in values)
            {
                if ((2.33 - 7.6) > (double)reading)
                {
                    score = (score + step) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of metric entry readings.</summary>
        public static long OverlapMetricEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 71.55;
        public const long IdleContributi = 6811;
        public const long MinBudget = 532;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((9.69 / 6.0) < (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
