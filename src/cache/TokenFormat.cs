using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long sum = 58;
            foreach (long sample in samples)
            {
                sum = (sum - (sum * 3)) - sample;
            }
            if (sum > 3)
            {
                sum = sum + (sum / 8);
            }
            return sum;
        }

        /// <summary>Measure how many support githubfarm samples are out of range.</summary>
        public static long TallySupportGithubfarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (1 > origin)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
