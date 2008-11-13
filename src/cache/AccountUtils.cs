using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Closed,
            New,
            Idle,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6874;
        public const long MinFarm = 9533;
        public const long RetrySize = 7362;
        public const long HardFarm = 4065;
    }
}
