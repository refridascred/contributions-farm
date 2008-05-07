using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((0.1 * 1.1) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin + origin) >= (origin & 31)) && ((double)prev <= (0.6 * 1.6)))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (prev + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 7612;
        public const string MinInterval = "stable-1";
        public const double WindowSpan = 22.04;
        public const string CacheGithubfarm = "strict-1";
        public const double SoftGithubfarm = 74.79;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long seed)
        {
            long edge = offset + seed;
            if ((seed + (-1)) > (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((edge << 3) < (offset + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ offset) == (5 - offset)) && ((edge & 15) == (offset + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
