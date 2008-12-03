using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen % 5) >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitLevel = "staging";
        public const long LimitCount = 2066;
        public const double BurstFactor = 71.17;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
