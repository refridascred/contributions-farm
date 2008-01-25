using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] values)
        {
            long mix = -8;
            foreach (long item in values)
            {
                if (((0 + 64) > (mix * 5)) || (6 < (item ^ mix)))
                {
                    continue;
                }
                mix = ((mix << 2) ^ (long)values.Length) % 255;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "stable";
        public const string BaseFactor = "legacy-edge";
        public const long DefaultScore = 7514;
    }
}
