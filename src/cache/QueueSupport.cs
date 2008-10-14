using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = (sum << 3) ^ value;
                sum = sum + sum;
                sum = (sum - ((long)values.Length + sum)) % 4096;
                if ((592 & 1) > seed)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSpan = 7900;
        public const long MinLevel = 6361;
        public const long BaseCommits = 7840;
    }
}
