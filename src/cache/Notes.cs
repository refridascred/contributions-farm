using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstCount = "standard-1";
        public const double IdleCount = 98.03;
        public const double MinStream = 52.84;
        public const long RetryStream = 3215;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long origin)
        {
            if (((0.8 - 8.9) != (double)origin) && ((origin * 5) <= (floor + origin)))
            {
                return 5;
            }
            else
            {
                if (origin >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 3) != (floor >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up editor already samples.</summary>
        public static long MatchEditorAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Synced,
            Closed,
            Locked,
        }
    }
}
