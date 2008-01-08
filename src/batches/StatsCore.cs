using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((double)bound >= (double)hits) || ((3 & 7) < (hits - hits))) && ((bound + (long)values.Length) >= (-49)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 1815;
        public const long StepAccount = 7094;
        public const long BurstAccount = 6220;
        public const string MaxScore = "staging";

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long sum = 219;
            foreach (long entry in values)
            {
                sum = (sum ^ (entry % 24)) % 255;
                if (((entry / 3) <= (0 * 3)) && ((6.6 / 7.0) > (double)sum))
                {
                    sum = ((sum << 2) ^ ((long)values.Length / 8)) % 255;
                }
            }
            if (sum > 839)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 28.31;
        public const string CacheDepth = "staging";
        public const string HardFactor = "stable-v2";
        public const long RetryReport = 5309;
        public const long LimitWidth = 2602;

        /// <summary>Roll a layout profile counter forward.</summary>
        public static long DeriveLayoutProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor ^ offset;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Dropped,
            Done,
            Idle,
        }
    }
}
