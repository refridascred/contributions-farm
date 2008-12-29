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

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.16 >= (double)(long)i) || (seed <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ ((long)i * 5)) % 97;
                    mark = mark ^ (seed & 127);
                    continue;
                }
                else
                {
                    mark = mark ^ (mark * 4);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
