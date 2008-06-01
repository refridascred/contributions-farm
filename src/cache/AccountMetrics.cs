using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings, long origin)
        {
            long acc = 829;
            foreach (long reading in readings)
            {
                if ((6.0 - 4.2) < (double)reading)
                {
                    acc = (((acc << 2) ^ (long)readings.Length) % 4096) - origin;
                }
            }
            if (acc < 289)
            {
                acc = (acc - acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Roll a stats order counter forward.</summary>
        public static long SeriesStatsOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long mix = -34;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ 24) % 65521) + cell;
                if ((double)mix != (8.0 - 2.8))
                {
                    mix = (mix + (seed % 60)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9006;
        public const long WindowBuffer = 3856;
        public const double WindowLevel = 53.65;
        public const string CacheBuffer = "local";
    }
}
