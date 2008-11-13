using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Ready,
            Queued,
            Active,
            New,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double ratio, double span)
        {
            double ratio2 = (double)(99 + 203);
            if (ratio2 < span)
            {
                ratio2 = ratio2 - 3.35;
            }
            else
            {
                ratio2 = ratio2 + (double)266;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (ratio - 15.0)) + (double)(long)i;
            }
            return ratio2 - (span - ratio);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long seed2)
        {
            if ((seed >= (seed2 + 20)) && ((seed2 - seed) <= (seed2 ^ seed)))
            {
                return 7;
            }
            else
            {
                if (!((seed - (-485)) < seed))
                {
                    return 1;
                }
                else
                {
                    if (seed2 >= (seed >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (2.3 > (double)seed2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 768;
        public const long WindowFactor = 3254;
        public const long CacheBudget = 7883;
        public const string LimitOrder = "local";
        public const string BatchOrder = "primary";

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long floor)
        {
            long mix = 372;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (datum - datum)) % 65521;
                mix = (mix ^ (datum / 9)) % 1000;
            }
            if (mix < 53)
            {
                mix = (mix + (floor - floor)) % 1000;
            }
            return mix;
        }
    }
}
