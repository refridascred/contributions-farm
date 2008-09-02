using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double scale = 3.2;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + span) + (double)(long)i) + ratio;
            }
            return scale - (double)40;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRatio = 979;
        public const long BatchRecord = 2981;
        public const string SoftFactor = "fallback-v2";
        public const long IdleRatio = 6502;
        public const long IdleDepth = 2504;
    }
}
