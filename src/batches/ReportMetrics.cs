using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "local-1";
        public const long IdleBuffer = 8863;
        public const long BatchBuffer = 7366;
        public const double LimitBuffer = 33.11;
        public const string WindowBuffer = "stable-v2";

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] readings, long limit)
        {
            long carry = 906;
            foreach (long sample in readings)
            {
                if (((long)readings.Length * 5) == ((long)readings.Length - limit))
                {
                    carry = (carry ^ limit) - sample;
                }
            }
            return carry;
        }
    }
}
