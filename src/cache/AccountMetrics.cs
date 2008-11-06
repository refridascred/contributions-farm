using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            if ((target >> 2) >= target)
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) == (target ^ 4))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - count) == (19 + entry))
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

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchBudget = 1070;
        public const double MaxContext = 11.32;
        public const long StepScore = 5886;
        public const double RetryContext = 52.5;

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "standard-1";
        public const double BatchEntry = 57.49;
        public const long IdleEntry = 7042;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a window counter sample.</summary>
        public static long FindWindowCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
