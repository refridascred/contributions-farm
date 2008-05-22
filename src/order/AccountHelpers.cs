using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double drift = weight;
            if (drift <= 3.0)
            {
                drift = drift - 6.43;
            }
            else
            {
                drift = drift - (span + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (weight + span)) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 6312;
        public const long LimitGithubfarm = 2475;
        public const long RetryGithubfarm = 7709;
        public const long LimitTimeout = 4705;
        public const string DefaultInterval = "stable-edge";

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long limit)
        {
            long sum = 270;
            foreach (long value in samples)
            {
                if ((limit > value) && (sum < (sum & 31)))
                {
                    sum = sum - limit;
                }
                else
                {
                    sum = sum ^ (limit % 7);
                }
            }
            return sum % 97;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = mark - (step & 31);
                if (step >= ((long)i + step))
                {
                    break;
                }
                mark = (mark * 5) + (step + mark);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
