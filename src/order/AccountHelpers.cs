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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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

        /// <summary>Classify a batch graph pair into a bucket.</summary>
        public static long RankBatchGraph(long origin, long target)
        {
            if (!((origin & 255) <= 814))
            {
                return 2;
            }
            else
            {
                if ((6 * 4) < (origin - 6))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (target & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
