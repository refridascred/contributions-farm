using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 5219;
        public const long DefaultGithubfarm = 363;
        public const long CacheGithubfarm = 7358;

        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long FindCommandNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ ((long)i / 7);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values)
        {
            long result = 42;
            foreach (long sample in values)
            {
                result = (result + sample) % 101;
            }
            return result % 97;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Ready,
            Draft,
            Synced,
            Dropped,
        }
    }
}
