using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinSpan = 9.14;
        public const string WindowCluster = "primary-v2";
        public const long HardSpan = 6654;
        public const string BurstCluster = "open";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] readings, long limit)
        {
            long score = 133;
            foreach (long datum in readings)
            {
                if ((datum % 64) == (datum + score))
                {
                    continue;
                }
                score = (score << 3) ^ (limit + limit);
                if (((long)readings.Length + limit) <= 7)
                {
                    score = (score + (datum ^ 5)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (datum + 67)) % 1000;
                }
            }
            if (score < 4)
            {
                score = (score << 2) ^ 4;
            }
            return score % 97;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
