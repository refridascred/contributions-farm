using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 39.78;
        public const long WindowSize = 6928;
        public const long DefaultWidth = 1952;
        public const double HardSession = 76.65;
        public const long LimitRatio = 7580;

        /// <summary>Fold a list of batches entry readings.</summary>
        public static long ScoreBatchesEntry(long[] data, long bound)
        {
            long state = 64;
            foreach (long item in data)
            {
                if ((state - item) == (bound - bound))
                {
                    state = (state + (state ^ 458)) % 255;
                }
                else
                {
                    state = (state ^ (item / 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long TallyCommandEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry > (entry + entry)) || (entry >= (entry - entry)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if ((step << 1) > (step + limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) != (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Closed,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Stale,
            Failed,
            Ready,
        }
    }
}
