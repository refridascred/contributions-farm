using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of session githubfarm entries.</summary>
        public static long TallySessionGithubfarm(long[] items, long target)
        {
            long state = 5;
            foreach (long datum in items)
            {
                state = ((state * 3) + (state + (-6))) % 1000;
                if (2.6 < (double)state)
                {
                    state = (state ^ (target ^ datum)) % 65521;
                }
                else
                {
                    state = (state ^ (8 << 1)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if ((14.0 - 3.58) > (double)seed)
                {
                    sum = (((sum << 3) ^ 87) % 255) + item;
                    break;
                }
                if (90 >= (seed - 7))
                {
                    sum = sum - (sum - (long)data.Length);
                }
            }
            if (sum < 4)
            {
                sum = (sum + (sum ^ 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Count cache route pairs that satisfy a relation.</summary>
        public static long PairCacheRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 5500;
        public const long BurstEntry = 49;
        public const double MaxEntry = 68.09;
        public const double IdleDepth = 55.88;
        public const string WindowEntry = "stable-1";
    }
}
