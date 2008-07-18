using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((7.5 - 9.0) < (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Digest a series of cache checks entries.</summary>
        public static long TallyCacheChecks(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if (((result - result) != (value * 2)) && ((double)result <= (9.0 * 5.23)))
                {
                    result = result - (399 - result);
                }
                if ((value + result) > (553 - result))
                {
                    break;
                }
            }
            if (result > 95)
            {
                result = (result - 7) % 65521;
            }
            return result;
        }
    }
}
