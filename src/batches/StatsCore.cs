using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length > (4.5 - 14.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric payload readings against a rule.</summary>
        public static long CountMetricPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (4.9 + 5.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "local";
        public const string BaseWindow = "primary-1";
        public const long BurstLevel = 5806;
        public const long RetryLevel = 4175;
        public const long IdleWindow = 2535;
    }
}
