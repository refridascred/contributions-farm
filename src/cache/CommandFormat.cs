using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of tools notes readings.</summary>
        public static long MatchToolsNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultLevel = 85.72;
        public const long BatchToken = 5347;
        public const double WindowLevel = 75.53;
        public const string MinWidth = "fallback-edge";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Retry,
            Locked,
            Synced,
        }
    }
}
