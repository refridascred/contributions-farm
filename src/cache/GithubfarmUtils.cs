using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up batches githubfarm samples.</summary>
        public static long MatchBatchesGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (total * 5);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
