using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            if ((bound / 4) == ((-5) & 3))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 5.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long bound)
        {
            if (((double)3 == (double)bound) && (5.5 > (double)bound))
            {
                return 6;
            }
            else
            {
                if (6 < limit)
                {
                    return 3;
                }
                else
                {
                    if ((bound % 7) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Closed,
            Locked,
            Dropped,
        }
    }
}
