using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4937;
        public const long WindowTimeout = 5460;
        public const double RetryScore = 30.91;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen * 4) < 16)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
