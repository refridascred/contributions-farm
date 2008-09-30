using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.48;
        public const string SoftStats = "staging-v2";
        public const long LimitStats = 8047;
        public const long BatchSpan = 35;
        public const long WindowStats = 2961;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a record cluster counter forward.</summary>
        public static long IterateRecordCluster(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total - (23 ^ step)) + (long)i2;
                    total = ((total * 5) + total) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
