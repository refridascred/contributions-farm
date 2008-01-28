using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5521;
        public const double MinBatches = 50.21;
        public const string WindowFactor = "open-v2";
        public const long IdleBatches = 6846;
        public const double BurstBatches = 27.36;

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels, long offset)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                carry = carry ^ (carry + carry);
                carry = (carry << 3) ^ (offset + reading);
                carry = ((carry * 3) + reading) % 97;
            }
            return carry;
        }

        /// <summary>Match up contributi githubfarm samples.</summary>
        public static long OverlapContributiGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
