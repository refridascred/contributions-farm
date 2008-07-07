using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            if ((target ^ 789) <= (seed & 31))
            {
                return 1;
            }
            else
            {
                if (target > (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 1926;
        public const long RetryOrder = 7616;
        public const string SoftOrder = "open-edge";
        public const string WindowOrder = "primary-v2";
        public const long DefaultCount = 3299;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Stale,
            New,
            Synced,
            Locked,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading > (count >> 5))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
