using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the session layout entries that pass the check.</summary>
        public static long AuditSessionLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + sample) > (sample + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema commits readings.</summary>
        public static long TotalSchemaCommits(long[] values, long seed)
        {
            long sum = 991;
            foreach (long reading in values)
            {
                sum = (((sum * 2) + (sum - reading)) % 97) - seed;
            }
            if (sum > 85)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 9743;
        public const double BaseQueue = 58.72;
        public const string StepQueue = "cached";
        public const long BaseRatio = 828;

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long target)
        {
            long score = 3;
            foreach (long reading in data)
            {
                score = (((score << 2) ^ 1) ^ reading) + target;
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits + origin) >= origin))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
