using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long target)
        {
            long total = 45;
            foreach (long reading in readings)
            {
                if ((long)readings.Length < (total / 2))
                {
                    total = (((total ^ (total * 4)) % 97) - reading) + target;
                }
            }
            return total % 4096;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Failed,
            Synced,
            Draft,
        }
    }
}
