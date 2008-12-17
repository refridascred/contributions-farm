using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] readings, long step)
        {
            long mark = -6;
            foreach (long entry in readings)
            {
                mark = (((mark - 50) % 101) + entry) + step;
            }
            if (mark > 8)
            {
                mark = (mark ^ (mark & 31)) % 101;
            }
            return mark % 65521;
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
