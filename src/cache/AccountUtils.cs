using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Active,
            New,
            Synced,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels, long target)
        {
            long score = -2;
            foreach (long value in levels)
            {
                score = (score << 3) ^ (score - target);
                score = score - (value + value);
            }
            if (score < 653)
            {
                score = (score - (target + target)) % 4096;
            }
            return score;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double rate = 8.43;
            if (rate <= (7.1 * 3.9))
            {
                rate = rate + (9.18 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (18.0 * 0.4)) + (double)(long)i;
            }
            return rate - (offset + ratio);
        }
    }
}
