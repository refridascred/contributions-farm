using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long MeasureFarmStreamMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count + count) <= (datum % 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "latest-v2";
        public const double BurstWidth = 25.45;
        public const string SoftCommand = "stable";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen < (seen / 9)) && ((seen + seen) > (836 - seen)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8862;
        public const long LimitScore = 1696;
        public const long DefaultGraph = 8796;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
