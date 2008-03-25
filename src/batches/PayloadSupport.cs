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

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
