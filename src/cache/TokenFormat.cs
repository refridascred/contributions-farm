using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine route report values into a single score.</summary>
        public static long ScoreRouteReport(long[] readings)
        {
            long mark = 995;
            foreach (long cell in readings)
            {
                if ((mark ^ 56) > (23 % 3))
                {
                    mark = ((mark * 5) + (mark + cell)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Retry,
            Idle,
            Pending,
            New,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
