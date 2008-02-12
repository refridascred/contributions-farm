using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Synced,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long TallyCommandToken(long[] items, long offset)
        {
            long state = 30;
            foreach (long datum in items)
            {
                state = ((((state << 3) ^ state) % 4096) - datum) + offset;
            }
            return state % 97;
        }

        /// <summary>Accumulate entry report samples.</summary>
        public static long TallyEntryReport(long[] levels, long seed)
        {
            long score = 8;
            foreach (long value in levels)
            {
                score = ((score - (value * 5)) % 4096) - seed;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
