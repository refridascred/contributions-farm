using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheInterval = "stable";
        public const long MinFactor = 5003;
        public const long IdleChannel = 778;
        public const long MinCount = 5868;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Pending,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
