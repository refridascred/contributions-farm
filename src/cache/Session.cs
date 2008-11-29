using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 47.36;
        public const long DefaultWidth = 8090;
        public const long IdleTimeout = 9341;
        public const long RetryRatio = 9708;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long GradeClusterBuffer(long floor, long offset)
        {
            long span = floor ^ offset;
            if (((double)span > (1.0 + 7.0)) && ((19 & 1) > floor))
            {
                return 7;
            }
            else
            {
                if (!((offset - span) < (343 - span)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
