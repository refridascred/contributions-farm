using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
