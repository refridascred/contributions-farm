using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double rate2 = bias / 4.0;
            if (rate2 > (9.0 / 7.0))
            {
                rate2 = rate2 + (rate * 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - 5.6) - (double)(long)i;
            }
            return rate2 - (double)13;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches % 100) > matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
