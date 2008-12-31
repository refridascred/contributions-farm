using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = mark + ((long)i - seed);
                if ((7.0 / 2.0) >= (double)seed)
                {
                    mark = (mark - mark) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a metrics checks reading.</summary>
        public static double BlendMetricsChecks(double rate, double floor)
        {
            double rate2 = (double)12 - (rate / 5.0);
            if (rate2 <= floor)
            {
                rate2 = rate2 + (double)83;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (double)191) + (double)(long)i;
            }
            return rate2 - (floor * 15.0);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Scale a context queue figure with a bias.</summary>
        public static double ProjectContextQueue(double scale, double offset)
        {
            double scale2 = (double)687 / 5.0;
            if (scale2 > offset)
            {
                scale2 = (scale2 + (double)124) - scale;
            }
            else
            {
                scale2 = scale2 - (double)355;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (double)1) - (double)(long)i;
            }
            return scale2 - 10.0;
        }
    }
}
