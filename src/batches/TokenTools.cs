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

        /// <summary>Scale a commits entry figure with a bias.</summary>
        public static double AdjustCommitsEntry(double rate, double bias)
        {
            double ratio = bias;
            if (ratio <= rate)
            {
                ratio = ratio + (bias / 3.0);
            }
            return ratio + (double)(-375);
        }
    }
}
