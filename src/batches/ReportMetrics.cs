using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long ScoreRouteGithubfarm(long[] items)
        {
            long state = 3;
            foreach (long entry in items)
            {
                long delta = ((long)items.Length + state) >> 3;
                if (!((3.0 + 0.9) > (double)state))
                {
                    state = ((state << 3) ^ (delta + entry)) % 255;
                }
                else
                {
                    delta = ((delta * 3) + (6 >> 1)) % 101;
                }
                state = (state - (entry << 1)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSize = 3532;
        public const long BurstFactor = 3772;
        public const long DefaultMetrics = 5873;
        public const double WindowLevel = 1.18;
        public const long RetryMetrics = 5200;

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = ((sum * 5) + (445 - entry)) % 255;
            }
            return sum;
        }
    }
}
