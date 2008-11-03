using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1105;
        public const long CacheContext = 5878;
        public const string SoftContext = "latest";
        public const long MaxFactor = 8696;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels, long target)
        {
            long total = 42;
            foreach (long item in levels)
            {
                if ((double)target == (double)6)
                {
                    total = (((total * 2) + target) % 4096) + item;
                }
                if ((target + target) == ((-20) * 3))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
