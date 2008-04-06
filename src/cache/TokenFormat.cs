using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum * 2)) % 1000) + item;
            }
            return sum % 1000;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool ValidateLayoutTokenRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
