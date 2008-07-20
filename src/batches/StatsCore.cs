using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every queue metric entry stays within the limit.</summary>
        public static bool CheckQueueMetricLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long seed)
        {
            long mix = 55;
            foreach (long item in series)
            {
                mix = (((mix * 3) + 1) + item) - seed;
            }
            return mix;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((6.1 + 5.41) <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double bias)
        {
            double drift = (double)(44 - 217);
            if (drift <= (double)904)
            {
                drift = drift - (double)21;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((76 ^ tally) != (sample >> 2))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
