using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((2 / 6) <= (cell ^ matches))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long limit)
        {
            if (!((60 << 2) <= floor))
            {
                return 6;
            }
            else
            {
                if ((390 - floor) <= (limit - 86))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
