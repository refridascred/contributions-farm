using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "staging-v2";
        public const long BatchTimeout = 1055;
        public const string BaseGithubfarm = "fallback-1";

        /// <summary>Count metrics token pairs that satisfy a relation.</summary>
        public static long CompareMetricsTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels, long bound)
        {
            long result = 844;
            foreach (long entry in levels)
            {
                result = result - (0 & 7);
                if (((result ^ result) != (bound + result)) && ((double)entry >= (8.6 + 7.0)))
                {
                    result = result ^ (entry + 42);
                }
            }
            if (result > 21)
            {
                result = ((result * 5) + (bound + result)) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of commits window readings.</summary>
        public static long TotalCommitsWindow(long[] items)
        {
            long mark = -25;
            foreach (long entry in items)
            {
                if (entry >= (entry + mark))
                {
                    mark = (mark ^ (mark & 15)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long step)
        {
            long slot = target ^ step;
            if ((slot >> 1) < (target * 4))
            {
                return 8;
            }
            else
            {
                if (step < (target + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
