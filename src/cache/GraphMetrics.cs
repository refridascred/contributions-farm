using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3788;
        public const long BatchTimeout = 785;
        public const long BaseStream = 4844;
        public const long WindowInterval = 6919;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2747;
        public const long IdleWindow = 8323;
        public const long DefaultRatio = 9384;
        public const long HardCount = 1937;
        public const long RetryWindow = 1514;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value <= 3.4)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
