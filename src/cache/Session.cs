using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstSpan = "cached-v2";
        public const long IdleGithubfarm = 1840;
        public const long HardGithubfarm = 36;
        public const long BatchGithubfarm = 1087;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)floor > (8.6 + 6.0))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
