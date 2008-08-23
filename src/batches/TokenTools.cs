using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long TallyFormatSupportHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >> 4) > hits)
                {
                    hits = ((hits + 3) - value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool GuardGithubfarmOrderBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long offset, long step)
        {
            long step2 = offset - step;
            if ((5.44 - 2.0) <= (double)step2)
            {
                return 2;
            }
            else
            {
                if ((47 >> 4) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
