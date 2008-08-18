using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Retry,
            Closed,
            Ready,
            Active,
        }

        /// <summary>Compare every pair of checks stats readings.</summary>
        public static long PairChecksStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples, long limit)
        {
            long mark = 617;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length <= (8.41 * 6.84))
                {
                    mark = (mark - (mark - sample)) - limit;
                    break;
                }
                if ((mark << 3) == (7 - 494))
                {
                    mark = ((mark << 3) ^ ((long)samples.Length << 1)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((5 % 10) != (cell >> 3))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((origin >> 4) <= (reading ^ reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
