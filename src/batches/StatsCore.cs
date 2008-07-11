using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Closed,
            Paused,
            Active,
            New,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen / 8) < (cell ^ cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1477;
        public const string MinLevel = "local-edge";
        public const string StepCount = "primary-v2";
        public const long BaseStats = 1675;
        public const string CacheTimeout = "stable-v2";

        /// <summary>Count the notes account entries that pass the check.</summary>
        public static long TallyNotesAccountHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value / 2) >= target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                mix = (mix + (sample << 3)) % 101;
                mix = (mix - (sample + sample)) % 4096;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftInterval = 44.52;
        public const long LimitCommits = 8499;
        public const long HardCount = 5600;
        public const double RetryScore = 90.34;
    }
}
