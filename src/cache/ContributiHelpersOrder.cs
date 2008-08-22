using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long limit)
        {
            long lane = seed + limit;
            if ((lane ^ lane) <= (limit << 2))
            {
                return 0;
            }
            else
            {
                if (((limit / 7) != (seed + lane)) && ((seed ^ limit) < lane))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 5) == (lane * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + lane) <= (limit / 9)) && (9 > (limit % 10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm cache series from a seed.</summary>
        public static long StepGithubfarmCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + acc) % 255;
                if ((6.4 - 19.0) >= (double)seed)
                {
                    acc = ((acc << 2) ^ (acc ^ seed)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                state = (state + (datum / 6)) - origin;
            }
            if (state > 71)
            {
                state = state + (state * 3);
            }
            return state % 4096;
        }
    }
}
