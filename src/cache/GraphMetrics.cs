using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Synced,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 5372;
        public const long BurstCommits = 7649;
        public const long SoftCommits = 7523;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long target, long target2)
        {
            long slot = target - target2;
            if (((target & 15) < (slot - 900)) && ((8.3 / 4.0) > (double)slot))
            {
                return 7;
            }
            else
            {
                if ((0.62 * 3.41) != (double)slot)
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (9.1 + 8.1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
