using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 2) ^ (carry * 2);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            New,
            Failed,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 4293;
        public const double LimitInterval = 85.78;
        public const long DefaultRatio = 1111;
        public const long IdleFactor = 4747;

        /// <summary>Digest a series of account commits entries.</summary>
        public static long DigestAccountCommits(long[] samples)
        {
            long result = 39;
            foreach (long entry in samples)
            {
                result = (result + result) - entry;
                result = result + ((-2) - 68);
            }
            return result % 1000;
        }
    }
}
