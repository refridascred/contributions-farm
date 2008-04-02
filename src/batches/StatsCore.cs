using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double drift = (floor * 2.58) * 10.0;
            if (drift <= (double)635)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (gain * 20.0);
            }
            return drift + 2.38;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long BucketMetricsReport(long target, long offset)
        {
            if ((double)target != (3.6 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)target != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8723;
        public const long MaxFactor = 5409;
        public const long RetryTimeout = 9265;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long mix = 250;
            foreach (long reading in readings)
            {
                mix = ((mix - (reading - 3)) % 4096) - bound;
            }
            return mix % 1000;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
