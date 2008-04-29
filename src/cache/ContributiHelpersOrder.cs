using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ ((long)i - (long)i)) % 97;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long SeriesSessionMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long ScoreStatsGithubfarm(long[] readings, long origin)
        {
            long result = 978;
            foreach (long value in readings)
            {
                result = (((result * 4) + origin) % 1000) - value;
                result = result + origin;
            }
            return result;
        }
    }
}
