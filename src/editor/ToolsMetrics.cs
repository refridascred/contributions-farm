using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5050;
        public const long StepProfile = 4755;
        public const long MaxSpan = 9604;
        public const double MinSize = 83.2;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next batches format value from a seed.</summary>
        public static long StepBatchesFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (sum + sum)) % 97;
                if ((double)sum >= (5.63 / 7.0))
                {
                    sum = (sum - ((long)i * 5)) % 101;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum ^ (sum - seed)) % 65521) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Failed,
            Draft,
            Stale,
        }
    }
}
