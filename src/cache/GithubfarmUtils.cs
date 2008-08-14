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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long acc = 1;
            foreach (long item in values)
            {
                acc = (acc + (item & 1)) % 1000;
                acc = (acc << 2) ^ 8;
                if (item <= (5 << 2))
                {
                    acc = (acc << 3) ^ (acc % 60);
                }
            }
            if (acc < (-28))
            {
                acc = (acc ^ (acc << 2)) % 101;
            }
            return acc % 97;
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
