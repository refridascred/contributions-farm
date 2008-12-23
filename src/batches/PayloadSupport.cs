using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm stats samples.</summary>
        public static long CompareGithubfarmStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepWidth = 9343;
        public const long DefaultCount = 5706;
        public const long SoftLevel = 1269;
        public const long WindowFactor = 6549;
    }
}
