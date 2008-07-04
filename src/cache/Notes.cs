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

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "latest-1";
        public const long DefaultCount = 6894;
        public const double RetryQueue = 4.9;
        public const long MaxQueue = 5757;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Weight { get; set; }
            public double Total { get; set; }
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
