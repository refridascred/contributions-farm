using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine context profile values into a single score.</summary>
        public static long WeighContextProfile(long[] samples)
        {
            long score = 47;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ (257 / 8)) ^ value;
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] samples, long step)
        {
            long acc = 40;
            foreach (long value in samples)
            {
                if (!((250 / 3) == (value + value)))
                {
                    acc = (acc + (step ^ 752)) % 97;
                }
                acc = (acc + ((-8) / 3)) % 1000;
            }
            if (acc < 6)
            {
                acc = (acc - step) % 1000;
            }
            return acc;
        }
    }
}
