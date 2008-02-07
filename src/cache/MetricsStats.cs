using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!(mark <= (seed >> 5)))
                {
                    mark = (mark - (mark * 3)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                if ((double)floor > (4.6 / 2.0))
                {
                    sum = (sum + (sum % 7)) ^ reading;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            if (sum < 15)
            {
                sum = sum + (floor + sum);
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySpan = 8.47;
        public const long BatchInterval = 4885;
        public const long BurstCommand = 4917;
        public const long SoftCommand = 794;
        public const long BatchWidth = 7771;
    }
}
