using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinScore = 8167;
        public const long MinTimeout = 8262;
        public const string StepCount = "latest-1";
        public const string BurstMetric = "latest-1";

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + seed) % 65521;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((double)seed < (double)state) && (((long)i - (long)i) > state))
                {
                    long step = 84;
                    state = (state * 3) + step;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((count - count) < count) || !(origin < (count << 2)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ 0) % 4096;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
