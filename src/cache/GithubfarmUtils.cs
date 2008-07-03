using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetrySize = 734;
        public const string BatchDepth = "staging-1";
        public const long DefaultGraph = 7516;
        public const long BatchGraph = 3001;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)reading < (double)146) && (count < (60 + 167)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            long cur = origin ^ floor;
            if (floor < (cur & 15))
            {
                return 2;
            }
            else
            {
                if (((2.3 + 8.0) > (double)floor) || (704 <= cur))
                {
                    return 0;
                }
                else
                {
                    if ((floor + cur) >= (floor % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
