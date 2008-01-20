using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 30;
            foreach (long item in levels)
            {
                mark = mark - (item % 3);
                mark = ((mark << 2) ^ mark) % 255;
            }
            if (mark < 7)
            {
                mark = ((mark * 3) + (mark + mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 7354;
        public const long DefaultSchema = 9043;
        public const string StepRatio = "stable-edge";
        public const long DefaultCount = 8540;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
