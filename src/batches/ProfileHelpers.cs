using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (long)readings.Length)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)6)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] samples, long seed)
        {
            long score = 5;
            foreach (long item in samples)
            {
                score = (score + (-91)) % 255;
                if ((item - item) >= (91 - seed))
                {
                    score = (score ^ score) % 97;
                }
                else
                {
                    score = (score * 3) + (3 + item);
                }
                if (6 >= (seed + score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 3693;
        public const string StepContributi = "cached-v2";
        public const long BurstContributi = 6880;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            New,
            Done,
            Dropped,
        }
    }
}
