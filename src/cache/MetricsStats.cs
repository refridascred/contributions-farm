using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                long next = (sum * 2) / 5;
                if ((bound + next) <= (bound << 2))
                {
                    sum = ((sum << 3) ^ (bound - sum)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
