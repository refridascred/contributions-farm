using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            long next = seed - floor;
            if ((double)seed <= (double)next)
            {
                return 4;
            }
            else
            {
                if ((double)floor == (11.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseLevel = 7404;
        public const long BaseInterval = 9444;
        public const long WindowRatio = 2783;
        public const string StepFactor = "local-v2";
        public const long MinDepth = 7870;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Pending,
            Idle,
        }
    }
}
