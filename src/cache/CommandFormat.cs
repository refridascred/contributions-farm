using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9447;
        public const string SoftGithubfarm = "staging-edge";
        public const string BurstLevel = "fallback-1";
        public const string DefaultFactor = "open-v2";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((875 - 9) < (floor / 8))
            {
                return 0;
            }
            else
            {
                if ((floor / 8) <= 802)
                {
                    return 2;
                }
                else
                {
                    if ((bound - floor) != (7 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long acc = 3;
            foreach (long value in series)
            {
                acc = ((acc * 5) + ((long)series.Length + acc)) ^ value;
            }
            return acc;
        }
    }
}
