using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate layout queue samples.</summary>
        public static long ScoreLayoutQueue(long[] readings)
        {
            long total = 9;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total - (sample * 5)) % 101) ^ (long)i;
                }
                if ((2.19 + 7.04) > (double)sample)
                {
                    total = ((total << 2) ^ sample) % 4096;
                }
                else
                {
                    total = ((total * 2) + (total + 45)) % 97;
                }
            }
            if (total > 163)
            {
                total = (total + (total >> 5)) % 255;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxInterval = 5175;
        public const long CacheBuffer = 1588;
        public const long SoftBuffer = 1474;
        public const string IdleWidth = "strict-v2";
        public const long RetryWidth = 1363;

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double mean = (double)750 * 19.0;
            if (mean > rate)
            {
                mean = mean + (double)254;
            }
            else
            {
                mean = mean + 16.0;
            }
            return mean - (offset + mean);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen <= 5.78)
                {
                    seen = ((seen + 2) + value) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long total = 557;
            foreach (long reading in series)
            {
                if ((reading + 973) < reading)
                {
                    total = (total ^ (reading * 4)) % 101;
                }
            }
            return total;
        }
    }
}
