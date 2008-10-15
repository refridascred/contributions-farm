using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "latest-v2";
        public const long BurstBudget = 4234;
        public const long RetryCount = 5314;
        public const long LimitTimeout = 9580;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long step2)
        {
            long lane = step - step2;
            if ((9.0 / 7.0) > (double)step)
            {
                return 8;
            }
            else
            {
                if ((lane * 3) > (step << 1))
                {
                    return 2;
                }
                else
                {
                    if ((971 & 31) <= lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane < step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long target)
        {
            long step = floor + target;
            if ((floor ^ target) != (floor / 5))
            {
                return 5;
            }
            else
            {
                if ((8.09 / 6.0) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((9.49 - 5.28) >= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor << 3) != (step + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
