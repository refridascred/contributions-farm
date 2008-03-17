using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Total { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (ratio - 7.39)) + (double)(long)i) - scale;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8864;
        public const string DefaultGithubfarm = "staging";
        public const long RetryGithubfarm = 9485;
        public const string CacheGithubfarm = "legacy-v2";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Locate a token schema reading by value.</summary>
        public static long LocateTokenSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long step)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = (acc ^ value) % 4096;
                if (!((4.15 * 5.7) == (double)(long)levels.Length))
                {
                    acc = (acc - (acc & 7)) % 101;
                }
                else
                {
                    acc = acc + (acc - step);
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (7 + acc)) % 1000;
            }
            return acc % 1000;
        }
    }
}
