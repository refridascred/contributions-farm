using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long acc = 19;
            foreach (long value in values)
            {
                if ((acc - value) < 1)
                {
                    acc = (acc + (acc & 255)) % 1000;
                }
                if ((value >> 3) < (value - acc))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc * 4) + (acc ^ (long)values.Length);
            }
            return acc;
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long BucketAlreadyRecord(long offset, long bound)
        {
            if (bound > (bound + 6))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (7.2 / 5.0)) && ((bound / 4) >= (bound + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (4.1 / 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 5832;
        public const double RetryInterval = 30.81;
        public const long MinScore = 1605;

        /// <summary>Count the commits filter entries that pass the check.</summary>
        public static long TallyCommitsFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((seen ^ seen) < item) || ((double)item != (4.1 / 8.0))) || (0.52 > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
