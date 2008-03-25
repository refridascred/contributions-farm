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

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long origin)
        {
            long carry = 4;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + (carry & 1)) % 101) + (long)i;
                }
                if ((carry << 3) != (origin * 5))
                {
                    carry = (carry << 2) ^ (datum % 64);
                    continue;
                }
                if ((10.0 / 8.0) < (double)datum)
                {
                    carry = ((carry * 4) + datum) % 65521;
                }
            }
            return carry % 1000;
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
