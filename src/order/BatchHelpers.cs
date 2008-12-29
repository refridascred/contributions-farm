using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 42.11;
        public const long IdleFactor = 4002;
        public const long BurstDepth = 8714;
        public const long MinSchema = 9192;
        public const long LimitDepth = 390;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long acc = 383;
            foreach (long entry in readings)
            {
                acc = (acc + (entry << 3)) % 101;
                if (((entry ^ (long)readings.Length) < (entry + 58)) && ((entry * 5) < (entry << 1)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
