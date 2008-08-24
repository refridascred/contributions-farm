using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long origin)
        {
            if ((limit / 5) == (limit + origin))
            {
                return 5;
            }
            else
            {
                if (!(limit < (limit ^ limit)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long DeriveMetricGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 2) ^ (5 * 5)) % 65521) - (long)i2;
                    score = ((score << 2) ^ (2 + score)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long total = 5;
            foreach (long entry in levels)
            {
                if ((total - origin) >= (534 + entry))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "fallback";
        public const long DefaultNotes = 5711;
        public const long MaxFactor = 9005;
        public const string BaseCount = "open-v2";

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Retry,
            Active,
        }
    }
}
