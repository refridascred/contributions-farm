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

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total + (total - 85)) ^ (long)i) + entry;
                    total = ((total * 2) + total) % 101;
                }
                total = (total + total) % 4096;
            }
            if (total < (-738))
            {
                total = total ^ (97 - total);
            }
            return total;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 5.76;
        public const double BaseBatch = 80.13;
        public const long DefaultBatch = 70;
        public const long HardTimeout = 3030;

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
