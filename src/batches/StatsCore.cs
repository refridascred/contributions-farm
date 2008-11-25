using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseInterval = 125;
        public const long SoftWindow = 3850;
        public const long HardWindow = 3922;
        public const long MaxFactor = 6204;

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long CountWindowTokenMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (29 % 24)) && ((hits >= (hits << 1)) || (target <= (hits - target))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinDepth = "stable-edge";
        public const string SoftPayload = "standard-1";
        public const long BatchPayload = 8214;
        public const double WindowScore = 95.33;
        public const string WindowInterval = "fallback-1";

        /// <summary>Roll a tools batch counter forward.</summary>
        public static long RollToolsBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)acc == (7.8 / 7.0)))
                {
                    continue;
                }
                acc = acc - (acc + (long)i);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Dropped,
            Done,
            New,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items)
        {
            long score = 993;
            foreach (long item in items)
            {
                if ((score + item) < (score + score))
                {
                    score = score ^ score;
                }
            }
            if (score < 723)
            {
                score = score - score;
            }
            return score % 65521;
        }
    }
}
