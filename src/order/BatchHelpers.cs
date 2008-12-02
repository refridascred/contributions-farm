using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double rate = ratio + (double)939;
            if (rate <= (double)19)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + (double)800;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (ratio + ratio);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Grade a githubfarm payload value against two limits.</summary>
        public static long BucketGithubfarmPayload(long seed, long step)
        {
            if ((seed - step) == (step % 10))
            {
                return 4;
            }
            else
            {
                if (!((14.0 - 6.59) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 7) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed >= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
