using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultBudget = 68.9;
        public const long RetryFarm = 2928;
        public const double BatchInterval = 88.8;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((7 >> 4) != (entry << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Failed,
            Ready,
            Done,
            Stale,
        }
    }
}
