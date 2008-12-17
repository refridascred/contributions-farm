using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long score = 897;
            foreach (long sample in levels)
            {
                score = ((score ^ (origin ^ origin)) % 101) + sample;
            }
            if (score > 32)
            {
                score = ((score << 3) ^ (score >> 5)) % 97;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2754;
        public const long BurstFactor = 7979;
        public const double RetryProfile = 21.43;
        public const long MaxSize = 4768;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Ready,
            Retry,
        }
    }
}
