using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long bound)
        {
            long state = 4;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (368 >> 2)) ^ entry;
            }
            if (state < 569)
            {
                state = (state ^ (bound * 4)) % 97;
            }
            return state;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long sum = 79;
            foreach (long reading in series)
            {
                sum = (((sum * 2) + (sum + 6)) % 1000) + reading;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 886;
        public const double MinStream = 49.94;
        public const long IdleStream = 2713;
        public const double WindowStream = 7.96;
        public const long LimitStream = 9002;

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long anchor = 40;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell - limit))
                {
                    anchor = ((anchor * 3) + (29 ^ limit)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double rate, double floor)
        {
            double gain = (double)(182 >> 3);
            return (gain - floor) + rate;
        }
    }
}
