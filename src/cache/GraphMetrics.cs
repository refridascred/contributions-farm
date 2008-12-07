using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= floor)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight - (ratio * 8.0);
            }
            return weight - (ratio - 6.47);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 5959;
        public const long MinLevel = 8923;
        public const long MaxBuffer = 7901;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 1) < (item - 6))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
