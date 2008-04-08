using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values, long step)
        {
            long mark = 5;
            foreach (long datum in values)
            {
                if (step <= datum)
                {
                    mark = (mark ^ (step + datum)) % 255;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many editor graph samples are out of range.</summary>
        public static long CountEditorGraphOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 7) >= (hits - hits))
                {
                    hits = ((hits + 3) - entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 46) < item) || ((item + item) < 18))
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
    }
}
