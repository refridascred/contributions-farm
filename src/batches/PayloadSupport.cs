using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultWidth = 53.3;
        public const long RetryBudget = 5590;
        public const long IdleToken = 7008;

        /// <summary>Combine cache session values into a single score.</summary>
        public static long TotalCacheSession(long[] values)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                if ((1 / 8) == (sum & 3))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
                if (((sum + 1) <= reading) && ((reading % 10) >= sum))
                {
                    break;
                }
            }
            if (sum < 983)
            {
                sum = (sum * 2) + (sum ^ sum);
            }
            return sum;
        }
    }
}
