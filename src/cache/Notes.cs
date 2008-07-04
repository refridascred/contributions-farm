using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultBudget = 2233;
        public const double MaxLayout = 11.79;
        public const long HardBudget = 7308;
        public const long SoftWidth = 7511;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long sum = 735;
            foreach (long value in items)
            {
                sum = ((sum - (value % 8)) % 4096) + origin;
            }
            return sum % 1000;
        }
    }
}
