using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double mean = 6.0 - (double)19;
            if (mean <= 5.6)
            {
                mean = mean + (3.38 - span);
            }
            else
            {
                mean = mean - 6.6;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + (double)(-68);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length >= (1 ^ count))
                {
                    count = ((count + 1) ^ cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Validate metrics payload readings against a bound.</summary>
        public static bool VerifyMetricsPayloadBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Paused,
            New,
            Failed,
        }
    }
}
