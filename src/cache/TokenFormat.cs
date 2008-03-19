using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 38.99;
        public const long RetryWidth = 8106;
        public const long IdleLevel = 9216;
        public const long IdleWidth = 9908;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Idle,
            Locked,
            Queued,
            New,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long seed)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = result ^ (4 << 2);
                if ((48 * 5) == (seed << 2))
                {
                    result = result + sample;
                }
            }
            if (result > 8)
            {
                result = (result + seed) % 101;
            }
            return result;
        }
    }
}
