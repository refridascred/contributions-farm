using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (64 < (count << 2))
                {
                    count = ((count + 2) ^ cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinCount = 64.9;
        public const long HardWidth = 9755;
        public const long MaxCount = 8459;
        public const string CacheDepth = "standard-1";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
