using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mark = 3;
            foreach (long value in readings)
            {
                if ((mark + (-3)) <= (mark ^ mark))
                {
                    break;
                }
                else
                {
                    mark = ((mark - ((long)readings.Length ^ 115)) % 65521) - value;
                }
                mark = (mark - ((long)readings.Length + mark)) % 101;
            }
            if (mark > 3)
            {
                mark = mark - (75 ^ (long)readings.Length);
            }
            return mark;
        }

        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long CountGraphWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) > (408 << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
