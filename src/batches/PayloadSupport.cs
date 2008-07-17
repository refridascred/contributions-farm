using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank already metric input into a small class.</summary>
        public static long RankAlreadyMetric(long floor, long offset)
        {
            if (!(((-8) + offset) != (offset - 5)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (9.84 + 11.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 10) > 38)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double load = (double)(71 & 7);
            if (load >= rate)
            {
                load = load + (bias - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + (double)279;
        }
    }
}
