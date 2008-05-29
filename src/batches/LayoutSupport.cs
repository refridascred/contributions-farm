using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "standard-1";
        public const string LimitGithubfarm = "open";
        public const long IdleDepth = 5846;

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "alpha";
        public const long CacheCommits = 2439;
        public const long IdleCommits = 2415;
        public const long WindowCommits = 1507;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((18 + count) == (entry & 255))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ ((long)i * 4)) % 101;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
