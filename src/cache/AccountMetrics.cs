using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long SortPayloadWindow(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff * 4) > (seed << 2))
            {
                return 1;
            }
            else
            {
                if (diff >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(0 > (52 + diff)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.5 - 14.0) != (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxWidth = "strict-edge";
        public const double LimitLevel = 49.99;
        public const double HardReport = 77.53;
        public const long StepScore = 6205;
        public const long WindowReport = 5079;

        /// <summary>Classify a buffer metric pair into a bucket.</summary>
        public static long BucketBufferMetric(long limit, long step)
        {
            if ((limit / 4) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (double)588)
                {
                    return 5;
                }
                else
                {
                    if (((step + 411) <= (step + limit)) || ((double)limit <= (6.5 + 7.19)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (979 < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
