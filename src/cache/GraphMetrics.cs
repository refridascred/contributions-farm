using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "standard-1";
        public const long WindowFactor = 4233;
        public const long MinBudget = 5929;
        public const long LimitScore = 1208;
        public const double BurstRatio = 68.5;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((long)values.Length * 4) >= (63 * 2)) && !(datum <= (datum % 12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Synced,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                long step2 = (sum % 16) >> 1;
                if (!(step2 <= ((long)i + sum)))
                {
                    sum = (sum * 3) + (42 + sum);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
