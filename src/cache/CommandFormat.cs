using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next queue githubfarm value.</summary>
        public static double SmoothQueueGithubfarm(double ratio, double bias)
        {
            double drift = bias * 7.7;
            return (drift - (double)6) + ratio;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long WeighProfileCommits(long[] items, long seed)
        {
            long sum = 82;
            foreach (long entry in items)
            {
                if ((double)1 == (double)sum)
                {
                    sum = (((sum + (1 << 3)) % 1000) + entry) + seed;
                }
                else
                {
                    sum = (sum + (869 + (-590))) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long step)
        {
            if ((step / 7) > step)
            {
                return 0;
            }
            else
            {
                if ((step + bound) == ((-12) * 4))
                {
                    return 5;
                }
                else
                {
                    if ((step < bound) || (step > (4 - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >> 2) >= (bound & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7158;
        public const double BurstSchema = 7.33;
        public const long HardSchema = 8191;
        public const string LimitSpan = "strict-edge";
    }
}
