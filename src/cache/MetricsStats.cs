using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRatio = "strict-1";
        public const long SoftRecord = 1742;
        public const long WindowRecord = 9583;
        public const double MaxRecord = 32.51;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long total = 537;
            foreach (long value in readings)
            {
                if (!((935 - (-98)) <= total))
                {
                    total = ((total << 2) ^ total) % 4096;
                    total = ((total * 2) + total) % 65521;
                }
                if ((value - value) <= total)
                {
                    total = ((total * 4) + (total >> 4)) % 101;
                }
                if (((2.7 / 6.0) == (double)value) || ((3.07 - 2.09) > (double)value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count report filter pairs that satisfy a relation.</summary>
        public static long MatchReportFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstScore = 68.87;
        public const long WindowFarm = 3191;
        public const long BurstFarm = 7888;
    }
}
