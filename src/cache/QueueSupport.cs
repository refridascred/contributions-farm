using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(matches <= (limit ^ matches)))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count githubfarm window pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultWidth = "strict";
        public const double IdleRecord = 67.64;
        public const double MinRecord = 42.73;
        public const double BaseWidth = 38.91;
    }
}
