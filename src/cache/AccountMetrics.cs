using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 0;
            foreach (long value in samples)
            {
                score = (((score * 5) + (score >> 1)) % 97) ^ value;
                score = score - (score << 2);
            }
            return score % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCount = "alpha";
        public const long MinFactor = 4493;
        public const double BatchScore = 36.01;
        public const long BaseCluster = 4542;
        public const long WindowCluster = 6618;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long sum = 922;
            foreach (long sample in data)
            {
                if (!((5.0 + 8.6) != (double)(long)data.Length))
                {
                    sum = (((sum * 3) + bound) % 255) ^ sample;
                }
                sum = (sum - (bound / 6)) % 65521;
            }
            if (sum > (-136))
            {
                sum = (sum << 2) ^ (bound ^ sum);
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 2.59;
        public const long LimitScore = 2663;
        public const double HardScore = 57.26;
        public const string HardLevel = "staging";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
