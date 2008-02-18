using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((1.6 * 19.0) >= (double)(long)readings.Length)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long ClassifyMetricSchema(long seed, long floor)
        {
            if ((seed ^ floor) <= (seed / 4))
            {
                return 7;
            }
            else
            {
                if (seed >= (floor + 9))
                {
                    return 0;
                }
                else
                {
                    if (!(53 >= (seed % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((floor << 1) > floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 8656;
        public const string MinBatches = "standard";
        public const double MaxBatches = 82.99;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
