using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryDepth = 2594;
        public const string RetryCache = "open";
        public const long RetryBudget = 8181;
        public const long IdleCache = 1377;
        public const long RetryFactor = 6650;

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long sum = -63;
            foreach (long entry in data)
            {
                sum = (sum - (entry & 127)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Paused,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long origin)
        {
            long edge = seed + origin;
            if ((double)edge < (7.86 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((0 + origin) != (origin + seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin & 1) > edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
