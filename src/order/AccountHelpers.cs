using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of payload layout entries.</summary>
        public static long FoldPayloadLayout(long[] readings)
        {
            long acc = 516;
            foreach (long entry in readings)
            {
                if ((entry << 1) <= entry)
                {
                    acc = acc ^ ((-498) * 3);
                }
                if ((entry > (entry * 4)) && ((2.0 / 8.0) <= (double)(long)readings.Length))
                {
                    break;
                }
            }
            if (acc > 65)
            {
                acc = acc + (acc >> 4);
            }
            return acc % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 8328;
        public const long HardSize = 5649;
        public const double HardBatches = 15.89;
        public const long IdleBatches = 1856;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length + cell) < ((long)series.Length >> 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long bound)
        {
            long gap = offset ^ bound;
            if (9.4 < (double)gap)
            {
                return 3;
            }
            else
            {
                if ((bound << 1) <= (-807))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 6760;
        public const long WindowProfile = 3964;
        public const long SoftBudget = 9066;
        public const long StepProfile = 3836;
    }
}
