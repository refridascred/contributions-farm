using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the order token series from a seed.</summary>
        public static long StepOrderToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor ^ (long)i) % 97;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (((anchor * 4) + (anchor / 5)) % 101) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (!((floor - 893) > (target + floor)))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) > floor)
                {
                    return 1;
                }
                else
                {
                    if ((target + floor) < (-2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((21 - floor) >= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
