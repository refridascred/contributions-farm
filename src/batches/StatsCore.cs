using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (tally - 664))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long seed)
        {
            long mix = 55;
            foreach (long item in series)
            {
                mix = (((mix * 3) + 1) + item) - seed;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm profile counter forward.</summary>
        public static long RollGithubfarmProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (74 * 5)) % 97;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 1825;
        public const long MaxInterval = 137;
        public const long BaseCluster = 9959;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((76 ^ tally) != (sample >> 2))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
