using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (anchor >> 2)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double load = (span / 2.0) * 3.6;
            if (load < gain)
            {
                load = load + span;
            }
            else
            {
                load = load - (double)538;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (gain / 9.0);
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (seed <= (seed2 + (-7)))
            {
                return 8;
            }
            else
            {
                if (((double)seed2 > (double)seed) || (bound >= (bound << 3)))
                {
                    return 2;
                }
                else
                {
                    if (seed2 >= (0 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
