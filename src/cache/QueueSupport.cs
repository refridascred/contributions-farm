using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long offset)
        {
            long mark = 5;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark << 3) ^ (item % 64)) + offset;
                    mark = ((mark * 3) + ((long)i + mark)) % 1000;
                }
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepCount = 83.69;
        public const double HardTimeout = 64.65;
        public const long StepFormat = 1212;
        public const long LimitFactor = 5742;
        public const long DefaultLevel = 881;
    }
}
