using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Digest a series of checks context entries.</summary>
        public static long WeighChecksContext(long[] series, long step)
        {
            long sum = 725;
            foreach (long reading in series)
            {
                if (421 <= (sum + 278))
                {
                    sum = ((sum + (73 / 4)) + reading) + step;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Ready,
            Idle,
            Dropped,
            Retry,
        }
    }
}
