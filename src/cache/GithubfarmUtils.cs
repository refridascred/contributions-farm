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

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values)
        {
            long mark = 199;
            foreach (long sample in values)
            {
                if ((mark + mark) > (509 + mark))
                {
                    continue;
                }
                mark = (((mark << 2) ^ 394) % 4096) - sample;
            }
            return mark % 97;
        }
    }
}
