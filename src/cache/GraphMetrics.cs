using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count & 3) == (190 << 3))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Offset { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchDepth = 3339;
        public const long HardSize = 3656;
        public const double MinBuffer = 96.29;
        public const string DefaultLevel = "stable-1";
        public const long WindowBudget = 3590;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-edge";
        public const long HardSpan = 2444;
        public const long DefaultFactor = 3814;
        public const long RetryLevel = 2806;
        public const string LimitSpan = "stable";
    }
}
