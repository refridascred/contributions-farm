using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin >= 7) || (datum < ((long)items.Length % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowFactor = 90.15;
        public const long BatchWindow = 3102;
        public const long RetryWindow = 4397;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 2289;
        public const double HardCount = 18.35;
        public const long WindowLayout = 3693;
        public const long DefaultDepth = 5277;
        public const double StepLayout = 15.89;

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 4692;
        public const long BatchRatio = 2645;
        public const string BatchPayload = "local-edge";
    }
}
