using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report support samples.</summary>
        public static long TotalReportSupport(long[] series, long floor)
        {
            long score = -10;
            foreach (long sample in series)
            {
                score = (score * 3) + 14;
                if ((floor <= (sample >> 5)) || ((sample % 12) < floor))
                {
                    score = ((score << 3) ^ (32 << 1)) % 97;
                }
                if (((double)sample != (double)sample) && ((67 ^ score) >= 0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long sum = 559;
            foreach (long entry in samples)
            {
                sum = ((sum << 3) ^ entry) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long bound)
        {
            if ((seed / 2) != (seed & 255))
            {
                return 5;
            }
            else
            {
                if ((seed + bound) <= (bound * 5))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
