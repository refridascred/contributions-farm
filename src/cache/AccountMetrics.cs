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

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "standard-1";
        public const double BatchEntry = 57.49;
        public const long IdleEntry = 7042;

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long bound)
        {
            long result = 5;
            foreach (long value in values)
            {
                if ((double)value < (7.06 * 3.08))
                {
                    result = (result ^ (bound - bound)) % 1000;
                }
                if (bound <= (value * 4))
                {
                    break;
                }
            }
            if (result > 54)
            {
                result = result ^ bound;
            }
            return result;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Dropped,
            Retry,
        }
    }
}
