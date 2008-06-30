using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long result = 969;
            foreach (long sample in levels)
            {
                if (((result << 2) < (result ^ sample)) || ((sample << 2) < (sample & 255)))
                {
                    result = result ^ result;
                }
            }
            return result;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long limit)
        {
            long total = 25;
            foreach (long item in series)
            {
                total = ((total + (limit + limit)) % 4096) + item;
                total = (total - (limit + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - (double)15;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Pending,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits != (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue session figure with a bias.</summary>
        public static double ProjectQueueSession(double bias, double span)
        {
            double rate = span * 8.4;
            if (rate <= 1.6)
            {
                rate = (rate + (rate / 8.0)) - bias;
            }
            else
            {
                rate = rate - (double)(-40);
            }
            return rate + rate;
        }
    }
}
