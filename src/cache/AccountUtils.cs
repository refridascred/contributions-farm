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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
