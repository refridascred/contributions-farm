using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings, long seed)
        {
            long sum = 25;
            foreach (long entry in readings)
            {
                if ((8.5 + 0.19) < (double)seed)
                {
                    sum = ((sum << 3) ^ (entry - seed)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 93.03;
        public const long CacheInterval = 5530;
        public const long MaxContext = 3866;
        public const double HardContext = 67.25;
    }
}
