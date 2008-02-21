using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long anchor = 69;
            foreach (long sample in values)
            {
                anchor = (anchor + (sample % 8)) % 255;
                anchor = (anchor * 3) + (sample + 56);
                if ((9.6 + 4.0) != (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 616)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleBudget = 62.1;
        public const long WindowFilter = 5565;
        public const string IdleFilter = "staging";
        public const long MaxFilter = 3470;
        public const long MinRatio = 1610;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long sum = 20;
            foreach (long sample in levels)
            {
                sum = (sum - (sample & 7)) - bound;
                sum = (sum << 2) ^ (sample % 12);
            }
            return sum;
        }
    }
}
