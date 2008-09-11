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

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool VerifyReportQueueBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > target)
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

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
