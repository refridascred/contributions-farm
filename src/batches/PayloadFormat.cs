using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long target)
        {
            long anchor = 32;
            foreach (long cell in series)
            {
                anchor = ((anchor << 3) ^ (35 >> 4)) % 4096;
                if (!(cell >= (target + cell)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long bound)
        {
            if ((target % 100) != (target / 9))
            {
                return 8;
            }
            else
            {
                if ((bound & 3) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((target + bound) > 71)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (4.0 + 3.62))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            New,
            Pending,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 9939;
        public const long MinMetrics = 4559;
        public const string DefaultSize = "alpha-1";
        public const long IdleMetrics = 9262;
    }
}
