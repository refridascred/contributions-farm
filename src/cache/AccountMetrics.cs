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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
