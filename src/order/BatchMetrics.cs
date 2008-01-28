using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long MeasureMetricsTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 5) == (entry ^ (long)samples.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 5126;
        public const long WindowOrder = 4432;
        public const long SoftOrder = 3128;
        public const long RetryOrder = 4936;
        public const long CacheOrder = 9752;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the token batches entries that pass the check.</summary>
        public static long MeasureTokenBatchesMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(((bound * 5) == (item - item)) && (953 < item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats context pair into a bucket.</summary>
        public static long GradeStatsContext(long seed, long bound)
        {
            if ((16.0 / 8.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (0.7 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((bound & 1) == (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double bias = (double)487 + (double)8;
            if (bias >= (double)38)
            {
                bias = (bias + (double)816) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (offset * 3.6)) + (double)(long)i;
            }
            return bias - (double)8;
        }
    }
}
