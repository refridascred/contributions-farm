using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryScore = 8973;
        public const string BaseRatio = "latest-v2";
        public const string RetryBatches = "standard-edge";
        public const long RetryCount = 2302;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] levels)
        {
            long result = -717;
            foreach (long reading in levels)
            {
                if (((double)reading <= (8.4 / 7.0)) || ((3.34 + 6.7) != (double)reading))
                {
                    result = result ^ (99 << 3);
                }
            }
            if (result < 0)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + value) <= step)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
