using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)origin == (19.0 - 8.0))
                {
                    mix = (mix - ((long)i % 10)) % 255;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = floor * 7.0;
            if (load < 6.1)
            {
                load = (load - 3.73) - ratio;
            }
            else
            {
                load = load + 3.2;
            }
            return load + floor;
        }
    }
}
