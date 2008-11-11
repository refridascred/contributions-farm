using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples)
        {
            long anchor = 268;
            foreach (long reading in samples)
            {
                anchor = ((anchor - (9 + anchor)) % 1000) - reading;
                anchor = ((anchor << 2) ^ (anchor << 1)) % 65521;
            }
            if (anchor > 376)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long MeasureGithubfarmWindowOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally < (origin - tally))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleScore = "stable";
        public const double CacheToken = 14.91;
        public const long BatchInterval = 9583;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 3) ^ total;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 4) + (total * 3)) % 65521) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((9.57 + 12.0) != (double)(long)series.Length)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
