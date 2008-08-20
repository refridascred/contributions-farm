using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long target, long offset)
        {
            if ((target % 7) == (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((offset / 6) < offset)
                {
                    return 3;
                }
                else
                {
                    if ((target < (offset - offset)) || ((8.0 - 1.2) < (15.0 / 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Paused,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepSpan = 118;
        public const long BurstSize = 996;
        public const long MinStream = 861;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            New,
            Ready,
            Failed,
        }
    }
}
