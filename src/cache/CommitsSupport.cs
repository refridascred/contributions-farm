using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long DeriveFilterContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - (floor + (long)i)) % 255;
                if ((mix <= (mix >> 1)) || (mix <= (long)i))
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long ClassifyContextGithubfarm(long origin, long seed)
        {
            long edge = origin + seed;
            if ((edge + origin) < (77 - 744))
            {
                return 2;
            }
            else
            {
                if ((0.1 + 5.5) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (7.2 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (edge + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double ratio = (double)((-804) << 2);
            if (ratio > ratio)
            {
                ratio = (ratio + bias) - gain;
            }
            else
            {
                ratio = ratio + (ratio * 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - 2.3;
        }
    }
}
