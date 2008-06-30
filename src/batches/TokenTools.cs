using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 2) ^ origin;
                acc = acc ^ (acc - (long)i);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)seed > 4.5)
                {
                    acc = acc + (acc ^ acc);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long acc = 619;
            foreach (long datum in items)
            {
                acc = (acc + (datum + acc)) % 101;
            }
            if (acc > 346)
            {
                acc = acc - (7 << 1);
            }
            return acc;
        }
    }
}
