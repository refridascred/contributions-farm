using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stream notes entries.</summary>
        public static long TotalStreamNotes(long[] items, long target)
        {
            long sum = 39;
            foreach (long item in items)
            {
                sum = (sum ^ item) + target;
            }
            return sum % 97;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total << 3) ^ (step % 97);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryBudget = "standard-v2";
        public const string IdleRoute = "fallback-1";
        public const long LimitCount = 6058;
        public const long HardRoute = 866;
        public const long BaseLevel = 9608;
    }
}
