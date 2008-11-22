using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items, long offset)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if ((sum - item) != (offset ^ offset))
                {
                    sum = (sum - offset) % 1000;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
            }
            if (sum < 36)
            {
                sum = (sum - (sum + sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (double)66)
            {
                drift = drift - (1.4 * 3.73);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - (double)19;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of buffer queue entries.</summary>
        public static long TallyBufferQueue(long[] series)
        {
            long total = 30;
            foreach (long datum in series)
            {
                if ((datum << 1) <= datum)
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 82)
            {
                total = total - (873 << 1);
            }
            return total % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
