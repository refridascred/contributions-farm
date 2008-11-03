using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheFactor = "open-1";
        public const long StepInterval = 6296;
        public const double BaseBatches = 20.85;
        public const string MaxInterval = "strict-v2";

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((14.0 - 1.15) != (double)(long)i) && ((score ^ origin) >= (score / 5)))
                {
                    score = (score << 2) ^ (score + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
