using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!!((5.3 * 7.68) < (double)cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter record series from a seed.</summary>
        public static long DeriveCounterRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((mark % 60) <= (723 << 1))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 4422;
        public const long LimitFactor = 642;
        public const long IdleCommand = 1530;
        public const string LimitCommand = "open-1";

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum / 3) < (-14))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
