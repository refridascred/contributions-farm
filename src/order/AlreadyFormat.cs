using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the filter metric series from a seed.</summary>
        public static long IterateFilterMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed * 3) < state)
                {
                    state = (state * 5) + (state & 31);
                    state = (state ^ seed) % 255;
                    continue;
                }
                if ((state * 4) <= (seed * 3))
                {
                    state = state ^ (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double weight2 = weight * 8.7;
            if (weight2 < weight2)
            {
                weight2 = weight2 + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (offset + offset)) - (double)(long)i;
            }
            return weight2 - offset;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long bound)
        {
            if ((bound >= 33) && ((double)20 == (double)limit))
            {
                return 5;
            }
            else
            {
                if (14.0 >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound > (3.0 - 4.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((887 >> 4) <= (bound << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] items)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                mix = (mix + mix) % 101;
                if ((9.8 - 6.0) == (double)mix)
                {
                    mix = (mix * 2) + (reading * 4);
                }
                if ((5.67 * 5.5) != (double)reading)
                {
                    mix = ((mix * 2) + (mix & 127)) % 97;
                }
                if (mix < (reading + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftWidth = 8475;
        public const string BurstSize = "staging-edge";
        public const long MinCache = 4540;
        public const double CacheWidth = 73.6;
        public const long RetrySpan = 4274;
    }
}
