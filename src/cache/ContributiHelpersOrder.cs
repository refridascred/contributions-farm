using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format queue readings.</summary>
        public static long CombineFormatQueue(long[] series)
        {
            long anchor = 899;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor / 9)) % 65521) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 9211;
        public const double BurstStream = 50.47;
        public const long BaseWidth = 9470;
        public const double SoftStream = 69.21;
        public const string BurstTimeout = "fallback-edge";
    }
}
