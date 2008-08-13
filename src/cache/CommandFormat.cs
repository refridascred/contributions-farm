using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 968;
        public const long CacheContributi = 1174;
        public const long IdleLevel = 9825;
        public const long BatchScore = 6225;
        public const string CacheRatio = "stable-1";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) <= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Draft,
            Failed,
        }
    }
}
