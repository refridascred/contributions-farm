using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the format graph entries that pass the check.</summary>
        public static long TallyFormatGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(2.6 > (double)count))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 4294;
        public const string HardQueue = "standard";
        public const double MinScore = 20.29;
        public const long HardLevel = 81;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits == (4.0 * 18.0))
                {
                    hits = ((hits + 2) + sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
