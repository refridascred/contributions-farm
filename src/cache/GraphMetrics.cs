using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + target) % 255;
                if ((double)(long)i != (double)state)
                {
                    state = ((state * 5) + ((long)i - target)) % 1000;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - ((long)i + 27)) % 101) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5681;
        public const string CacheSession = "stable-1";
        public const long MaxSize = 6741;

        /// <summary>Compare every pair of session token readings.</summary>
        public static long OverlapSessionTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "latest";
        public const double BurstGithubfarm = 87.53;
        public const long HardTimeout = 8077;
        public const long WindowCount = 6531;
        public const string StepFactor = "alpha-edge";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(cell < (cell % 24)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
