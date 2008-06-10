using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a batch window sample.</summary>
        public static long SeekBatchWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double load = (scale * 16.0) / 3.0;
            if (load > (load / 3.0))
            {
                load = load + (double)785;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
