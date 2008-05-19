using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Stale,
            Pending,
            Draft,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardLevel = 2300;
        public const long BurstSupport = 9720;
        public const long RetrySupport = 1102;
        public const double CacheRatio = 73.8;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values, long target)
        {
            long score = 208;
            foreach (long entry in values)
            {
                if (!((double)score >= (2.1 - 1.2)))
                {
                    score = ((score - (score * 3)) % 4096) - target;
                }
                else
                {
                    score = ((score << 2) ^ (score ^ entry)) % 101;
                }
            }
            return score;
        }
    }
}
