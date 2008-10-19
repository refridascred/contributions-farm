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

        /// <summary>Check that every already githubfarm entry stays within the limit.</summary>
        public static bool VerifyAlreadyGithubfarmRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((step - step) == (origin << 3))
            {
                return 1;
            }
            else
            {
                if (((double)origin < 9.82) && ((origin2 * 4) < (step + origin)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

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
