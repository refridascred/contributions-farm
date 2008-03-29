using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 1) >= (long)readings.Length)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6576;
        public const double LimitBatch = 73.25;
        public const double WindowSpan = 17.83;
        public const double WindowBatch = 96.76;
        public const long IdleRatio = 5449;
    }
}
