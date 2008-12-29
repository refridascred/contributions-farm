using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long target, long seed)
        {
            long lane = target ^ seed;
            if ((target + 52) <= (421 - seed))
            {
                return 5;
            }
            else
            {
                if ((lane < (4 % 97)) && ((seed + 0) != (seed * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)lane <= 8.7)
                    {
                        return 8;
                    }
                    else
                    {
                        if (2.1 > (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double gain2 = 1.4;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
