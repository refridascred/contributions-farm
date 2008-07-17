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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long bound)
        {
            long anchor = 990;
            foreach (long reading in readings)
            {
                anchor = ((anchor << 2) ^ (reading ^ 32)) % 4096;
                if ((double)bound < (6.0 - 2.7))
                {
                    anchor = (anchor ^ (reading - 54)) % 4096;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }
    }
}
