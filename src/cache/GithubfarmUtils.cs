using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((step << 3) == (count << 1))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 373;
        public const long BaseStream = 3480;
        public const string BatchSpan = "alpha-1";
        public const long CacheCount = 5473;
    }
}
