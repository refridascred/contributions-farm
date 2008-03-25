using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long AuditMetricsStatsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((origin + value) > 48)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the command already entries that pass the check.</summary>
        public static long MeasureCommandAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + hits) > (4 / 8))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples, long target)
        {
            long result = -954;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 3) >= 319)
                {
                    result = ((result * 4) + item) % 1000;
                }
                else
                {
                    result = result - (result * 5);
                }
            }
            if (result > 70)
            {
                result = (result << 3) ^ (target + result);
            }
            return result;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Closed,
            Pending,
            New,
            Idle,
        }
    }
}
