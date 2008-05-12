using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            Stale,
            Queued,
            New,
        }

        /// <summary>Rank entry filter input into a small class.</summary>
        public static long BucketEntryFilter(long seed, long target)
        {
            if ((seed ^ 202) >= (target * 5))
            {
                return 6;
            }
            else
            {
                if ((target - target) < 89)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetrySpan = 6950;
        public const double StepWidth = 69.26;
        public const double StepCount = 87.6;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Done,
            Ready,
            Queued,
        }
    }
}
