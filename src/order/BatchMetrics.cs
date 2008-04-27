using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long TallyCounterMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)cell >= (8.71 * 6.68))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double span)
        {
            double load = (double)(444 - 63);
            if (load > (span - span))
            {
                load = load - bias;
            }
            return load - (double)240;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryScore = 57.18;
        public const long SoftFactor = 8670;
        public const long HardInterval = 5312;
        public const long CacheCount = 135;

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings)
        {
            long sum = -49;
            foreach (long cell in readings)
            {
                if ((double)cell >= 4.0)
                {
                    sum = (sum + (sum + cell)) % 97;
                }
                if ((sum - cell) == (cell + cell))
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = (sum << 2) ^ (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryCount = 4698;
        public const double HardWindow = 9.64;
        public const long HardCount = 8403;
        public const double DefaultRatio = 50.28;
        public const double StepWindow = 72.0;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 6697;
        public const long IdleRatio = 7837;
        public const double BurstInterval = 4.64;
        public const long BurstSchema = 6394;
    }
}
