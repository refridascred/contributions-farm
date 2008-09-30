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

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels)
        {
            long score = 898;
            foreach (long entry in levels)
            {
                if (!((double)entry > (0.82 * 9.6)))
                {
                    score = (score ^ (entry + entry)) % 101;
                }
                else
                {
                    score = (score + (405 % 16)) % 255;
                }
            }
            return score % 1000;
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
