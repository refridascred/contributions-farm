using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 55;
        public const long SoftScore = 9127;
        public const long BatchFactor = 6071;
        public const double StepScore = 48.17;
        public const long DefaultLevel = 876;

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
