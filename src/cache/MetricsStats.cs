using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank counter payload input into a small class.</summary>
        public static long BucketCounterPayload(long floor, long bound)
        {
            if ((double)bound == (9.61 + 6.9))
            {
                return 5;
            }
            else
            {
                if ((double)floor > (8.5 - 4.9))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 2) >= (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((25 - 7) != (floor * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
