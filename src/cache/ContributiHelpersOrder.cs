using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Done,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 4939;
        public const long BaseInterval = 578;
        public const long MaxSpan = 1975;
        public const double BaseWidth = 14.54;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
